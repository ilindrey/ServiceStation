using System.Drawing;
using System.Threading.Tasks;
using ServiceStation.GridView;
using ServiceStation.InterfacesView;

namespace ServiceStation.Presenter
{
    internal class JournalsPresenter<TEntity> : BasePresenter<IJournalView> where TEntity : class
    {
        internal object Info;
        internal BaseJournal<TEntity> Journal;


        internal JournalsPresenter(IJournalView view, BaseJournal<TEntity> journal) : base(view)
        {
            Journal = journal;
        }
        

        protected override void SubscribeEvent()
        {
            View.Add += async () => await Journal.AddRecord();
            View.Edit += async () => await Journal.EditRecord();
            View.Delele += async () => await Journal.DeleteRecord();

            View.Seach += s => Journal.Filter(s);

            View.Loading += View_Loading;

            View.Choose += View_Choose;
        }

        private async Task View_Loading()
        {
            await this.Journal.Update();


            if (this.Journal is CarJournal)
            {
                View.ClientZoneSize = new Size(950, 500);
                View.Title = string.Concat("Автомобили заказчика");
            }
            else if (this.Journal is ContactPersonJournal)
            {
                View.ClientZoneSize = new Size(950, 500);
                View.Title = string.Concat("Контактные лица заказчика");
            }
            else if (this.Journal is PowerOfAttorneyJournal)
            {
                View.ClientZoneSize = new Size(950, 500);
                View.Title = string.Concat("Доверенности");
            }
            else if (this.Journal is MarkJournal)
            {
                View.ClientZoneSize = new Size(950, 500);
                View.Title = string.Concat("Справочник марок автомобилей");
            }
            else if (this.Journal is ModelJournal)
            {
                View.ClientZoneSize = new Size(950, 500);
                View.Title = string.Concat("Справочник моделей автомобилей");
            }
            else if (this.Journal is UnitJournal)
            {
                View.ClientZoneSize = new Size(950, 500);
                View.Title = string.Concat("Справочник единиц измерения");
            }
            else if (this.Journal is EmployeeJournal)
            {
                View.ClientZoneSize = new Size(950, 500);
                View.Title = string.Concat("Справочник сотрудников");
            }
            else if (this.Journal is ContractorJournal)
            {
                View.ClientZoneSize = new Size(1150, 600);
                View.Title = string.Concat("Справочник котрагентов");
            }
            else if (this.Journal is ReasonJournal)
            {
                View.ClientZoneSize = new Size(1150, 600);
                View.Title = string.Concat("Справочник причин обращения");
            }
            else if (this.Journal is NomenclatureJournal)
            {
                View.ClientZoneSize = new Size(1215, 550);
                View.Title = string.Concat("Справочник номенклатур");
            }
            else if (this.Journal is WorkingHourJournal)
            {
                View.ClientZoneSize = new Size(950, 500);
                View.Title = string.Concat("Справочник нормо-часов");
            }
            else if (this.Journal is OptionJournal)
            {
                View.ClientZoneSize = new Size(950, 500);
                View.Title = string.Concat("Справочник комплектаций");
            }
            else if (this.Journal is PostJournal)
            {
                View.ClientZoneSize = new Size(950, 500);
                View.Title = string.Concat("Справочник должностей сотрудников");
            }
        }

        private async Task View_Choose()
        {
            if (View.Grid.SelectedCells.Count > 0)
            {
                bool successfully = true;


                if (Journal is OptionJournal)
                {
                    successfully = (bool)await this.Journal.GetInfo();
                }
                else if (Journal is ReasonJournal)
                {
                    Info = await this.Journal.GetInfo();

                    if (Info == null)
                        successfully = false;
                }
                else
                {
                    this.Info = await this.Journal.GetInfo();
                }


                if (successfully)
                    View.Close();
            }
        }
    }
}