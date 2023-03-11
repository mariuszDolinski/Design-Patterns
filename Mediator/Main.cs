//Mediator  - s�u�y do obs�ugi komunikacji pomi�dzy wieloma obiektami r�znych klas, kt�rych zachowanie zale�y 
//            od siebie, np. gdy mamy wiele r�nych formatek w WinForm i stan jednych zale�y od stanu innych
//            Potrzebny jest interejs IMediator z metod� s�u�ac� do komunikacji i klasa mediatora,
//            kt�r� tutaj jest RegisterClientView
namespace Mediator
{
    public partial class MainWindow : Form
    {
        private MRadioButton fRadioButton;
        private MRadioButton pRadioButton;
        private MButton clearButton;

        public MainWindow()
        {
            InitializeComponent();
            fRadioButton = new MRadioButton(rbFirm);
            pRadioButton = new MRadioButton(rbPerson);
            clearButton = new MButton(buttonClear);

            new RegisterClientView(fRadioButton, pRadioButton, clearButton, labelFirstName, labelName,
                labelNR, textBoxFirstName, textBoxName, textBoxNR, textBoxStreet, textBoxCity,
                textBoxPostal, comboBoxCountry);
        }


    }
}