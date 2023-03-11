//Mediator  - s³u¿y do obs³ugi komunikacji pomiêdzy wieloma obiektami róznych klas, których zachowanie zale¿y 
//            od siebie, np. gdy mamy wiele ró¿nych formatek w WinForm i stan jednych zale¿y od stanu innych
//            Potrzebny jest interejs IMediator z metod¹ s³u¿ac¹ do komunikacji i klasa mediatora,
//            któr¹ tutaj jest RegisterClientView
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