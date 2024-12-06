using Vehicle_Management.Business;
using Vehicle_Management.DataAccess.Models;

namespace Vehicle_Management.Presentation
{
    public partial class CreateClient : Form
    {
        private int foreignid;
        public CreateClient(int userid)
        {
            InitializeComponent();
            this.foreignid = userid;
        }

        private void Confirm_Creation_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = datebirth.Value;
                DateOnly birthDateOnly = DateOnly.FromDateTime(selectedDate);

                ClientDTO clientDTO = new ClientDTO()
                {
                    Fullname = txtfullname.Text,
                    PhoneNumber = txtphone.Text,
                    Email = txtemail.Text,
                    Address = txtaddress.Text,
                    DriversLicence = txtlicense.Text,
                    BirthDate = birthDateOnly,
                    UserId = foreignid,
                };
                clientDTO.Validate(clientDTO);
                Client client = new Client();
                client.AddClient(clientDTO);
                MessageBox.Show("Cuenta Creada Correctamente.");
                this.DialogResult = DialogResult.Cancel;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


        }
        private void CreateClient_Load(object sender, EventArgs e)
        {

        }
    }
}
