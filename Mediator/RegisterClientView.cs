namespace Mediator
{
    internal class RegisterClientView : IMediator
    {
        private MRadioButton _radioButtonF;
        private MRadioButton _radioButtonP;
        private MButton _buttonClear;
        private Label _labelFirstName;
        private Label _labelName;
        private Label _labelNR;
        private TextBox _textBoxFirstName;
        private TextBox _textBoxName;
        private TextBox _textBoxRN;
        private TextBox _textBoxStreet;
        private TextBox _textBoxCity;
        private TextBox _textBoxPostal;
        private ComboBox _comboBoxCountry;

        public RegisterClientView(MRadioButton radioButtonF, MRadioButton radioButtonP, MButton clear,
            Label firstName, Label name, Label nr, TextBox firstNameTB, TextBox nameTB,
            TextBox rnTB, TextBox streetTB, TextBox cityTB, TextBox postalTB, ComboBox countryCB)
        {
            _radioButtonF = radioButtonF;
            _radioButtonP = radioButtonP;
            _buttonClear = clear;
            _labelFirstName = firstName;
            _labelName = name;
            _labelNR = nr;
            _textBoxFirstName = firstNameTB;
            _textBoxName = nameTB;
            _textBoxRN = rnTB;
            _textBoxStreet = streetTB;
            _textBoxCity = cityTB;
            _textBoxPostal = postalTB;
            _comboBoxCountry = countryCB;

            _radioButtonF.SetMediator(this);
            _radioButtonP.SetMediator(this);
            _buttonClear.SetMediator(this);

        }

        private void firmSetUp()
        {
            _labelFirstName.Visible = false;
            _textBoxFirstName.Visible = false;
            _labelName.Text = "Nazwa firmy:";
            _labelNR.Text = "REGON:";
            _labelNR.Location = new Point(70, 139);
            _labelName.Location = new Point(26, 102);
        }
        private void personSetUp()
        {
            _labelFirstName.Visible = true;
            _textBoxFirstName.Visible = true;
            _labelName.Text = "Nazwisko:";
            _labelNR.Text = "NIP:";
            _labelNR.Location = new Point(102, 139);
            _labelName.Location = new Point(52, 102);
        }
        private void clearForm()
        {
            _textBoxFirstName.Clear();
            _textBoxName.Clear();
            _textBoxRN.Clear();
            _textBoxStreet.Clear();
            _textBoxCity.Clear();
            _textBoxPostal.Clear();
            _comboBoxCountry.SelectedIndex = 0;
        }

        public void Notify(Component sender, Args arg)
        {
            switch (arg)
            {
                case Args.RADIO_BUTTON_CHECKED:
                    if(sender == _radioButtonF)
                    {
                        firmSetUp();
                    }
                    else
                    {
                        personSetUp();
                    }
                    break;
                case Args.BUTTON_CLEAR_CLICKED:
                    clearForm();
                    break;
            }
            
        }
    }
}
