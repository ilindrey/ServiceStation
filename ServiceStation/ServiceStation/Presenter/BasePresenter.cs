using System.Threading.Tasks;
using ServiceStation.InterfacesView;

namespace ServiceStation.Presenter
{
    //delegate void Save();
    internal abstract class BasePresenter<TView> : Message
    {
        protected TView View { get; set; }

        protected BasePresenter(TView view)
        {
            View = view;
            SubscribeEvent();
        }


        protected abstract void SubscribeEvent();
    }

    internal abstract class BasePresenter<TView, TIdentifier> : Message
    {
        private string _messageSaveConfirmation;

        protected ActionAsync Query;
        protected bool openView = false;

        protected TView View { get; set; }
        protected TIdentifier Identifier { get; set; }

        protected async Task<bool> VerificationSaved()
        {
            openView = true;

            if (Identifier == null && ShowConfirmation(_messageSaveConfirmation))
                await SaveAsync();

            openView = false;

            if (Identifier == null)
                return false;

            return true;
        }


        protected BasePresenter(TView view)
        {
            View = view;

            SubscribeEvent();
        }


        protected BasePresenter(TView view, string messageSaveConfirmation)
        {
            View = view;
            _messageSaveConfirmation = messageSaveConfirmation;

            SubscribeEvent();
        }

        protected BasePresenter(TView view, TIdentifier identifier, string messageSaveConfirmation)
        {
            View = view;
            _messageSaveConfirmation = messageSaveConfirmation;
            Identifier = identifier;

            Query += QueryInfo;
            SubscribeEvent();
        }


        protected BasePresenter(TView view, TIdentifier identifier)
        {
            View = view;
            Identifier = identifier;

            Query += QueryInfo;
            SubscribeEvent();
        }


        protected abstract Task QueryInfo();
        protected abstract void SubscribeEvent();
        protected abstract Task SaveAsync();


        protected string GetNullValue(string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
                return text;
            return null;
        }
    }
}