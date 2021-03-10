namespace Presentation.Commons
{
    public abstract class BasePresentor<TView> : IPresenter where TView : IView
    {
        protected TView View { get; private set; }
        protected IApplicationController Controller { get; private set; }

        protected BasePresentor(IApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        public void Run()
        {
            View.Show();
        }
    }

    public abstract class BasePresentor<TView, TArg> : IPresenter<TArg> where TView : IView
    {
        protected TView View { get; private set; }
        protected IApplicationController Controller { get; private set; }

        protected BasePresentor(IApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        public abstract void Run(TArg argument);
    }
}
