using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFWinforms;
using ServiceStation.Model;

namespace ServiceStation.GridView
{
    internal abstract class BaseJournal<TEntity> : Message where TEntity : class
    {
        private int _indexColumn;
        private int _indexRow;
        private EntityDataSource _source;


        protected DataGridView DGVJournal { get; set; }
        protected BindingSource Binding { get; set; }


        protected bool ExistsRecord
        {
            get
            {
                if (DGVJournal.SelectedCells.Count > 0)
                    return true;
                return false;
            }
        }
        
        protected TEntity Item
        {
            get
            {
                if (!ExistsRecord)
                    return null;
                return (TEntity)DGVJournal.CurrentRow.DataBoundItem;
            }
        }


        #region Abstract Method
        protected abstract void OperationColumn();
        internal abstract Task AddRecord();
        internal abstract Task EditRecord();
        internal abstract Task DeleteRecord();
        internal abstract Task<object> GetInfo();
        protected abstract Task<IEnumerable<TEntity>> QueryData();
        internal abstract void Filter(string text);
        #endregion


        protected BaseJournal(DataGridView journal)
        {
            DGVJournal = journal;
            if(DGVJournal != null)
            {
                DGVJournal.ReadOnly = true;
                DGVJournal.AllowUserToAddRows = false;
                DGVJournal.AllowUserToDeleteRows = false;
                DGVJournal.MultiSelect = false;
                DGVJournal.StandardTab = true;
                DGVJournal.AutoGenerateColumns = true;
                DGVJournal.BackgroundColor = SystemColors.ButtonFace;
                DGVJournal.BorderStyle = BorderStyle.Fixed3D;
                DGVJournal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            }
        }


        internal async Task Update()
        {
            try
            {
                var list = await QueryData();
                
                if (list == null)
                    throw new ArgumentNullException();

                if (Binding == null)
                {
                    Binding = new BindingSource();
                    _source = new EntityDataSource();
                    
                    _source.DbContextType = typeof(DbSSContext);
                    
                    Binding.SuspendBinding();
                    
                    Binding.DataSource = new EntityBindingList<TEntity>(_source, list, null);
                    DGVJournal.DataSource = Binding;
                    
                    OperationColumn();
                    
                    Binding.ResumeBinding();

                    SetSelectCell();
                }
                else
                {
                    RememberSelectCell();

                    Binding.SuspendBinding();

                    Binding.DataSource = new EntityBindingList<TEntity>(_source, list, null);

                    Binding.ResumeBinding();

                    SetSelectCell();
                }

            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
        
        protected void WightColumn(string columnName, int wight)
        {
            DGVJournal.Columns[columnName].Width = wight;
        }

        // Запомнить текущию выделеную ячейку
        private void RememberSelectCell()
        {
            if (DGVJournal.ColumnCount > 0 && ExistsRecord && DGVJournal.CurrentCell != null)
            {
                _indexRow = DGVJournal.CurrentCell.RowIndex;
                _indexColumn = DGVJournal.CurrentCell.ColumnIndex;
            }
        }

        private void SetSelectCell()
        {
            if (DGVJournal.ColumnCount > 0 && ExistsRecord)
            {
                while (DGVJournal.Columns[_indexColumn].Visible == false)
                {
                    _indexColumn++;
                }
                while (_indexRow > DGVJournal.Rows.Count - 1)
                {
                    _indexRow--;
                }
                DGVJournal.CurrentCell = DGVJournal[_indexColumn, _indexRow];
            }
        }
    }
}
