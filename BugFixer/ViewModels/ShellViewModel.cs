using Caliburn.Micro;

namespace BugFixer.ViewModels
{
    public class ShellViewModel : Screen
    {
        public ShellViewModel()
        {
            FixedBugs = 0;
            MAX_BUGS = 30;
        }
        
        private int MAX_BUGS;

        private int _fixedBugs;

		public int FixedBugs
		{
            get
            {
                return _fixedBugs;
            }
            set
            {
                _fixedBugs = value;
                NotifyOfPropertyChange(() => FixedBugs);
            }
		}

        public bool CanFixBug(int fixedBugs)
        {
            return fixedBugs < MAX_BUGS;
        }

        public void FixBug(int fixedBugs)
        {
            FixedBugs++;
        }

	}
}
