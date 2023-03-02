namespace Mediator
{
    public partial class MainWindow : Form
    {
        private MRadioButton fRadioButton;
        private MRadioButton pRadioButton;

        public MainWindow()
        {
            InitializeComponent();
            fRadioButton = new MRadioButton(rbFirm);
            pRadioButton = new MRadioButton(rbPerson);

            new RegisterClientView(fRadioButton, pRadioButton, labelFirstName, labelName,
                labelNR, textBoxFirstName);
        }


    }
}