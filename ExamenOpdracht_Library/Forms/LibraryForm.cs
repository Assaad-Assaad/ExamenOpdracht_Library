using Dapper;
using ExamenOpdracht_Library.Classes;
using ExamenOpdracht_Library.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ExamenOpdracht_Library.Repositories;

namespace ExamenOpdracht_Library
{
    public partial class LibraryForm : Form
    {

        private readonly MemberRepository _memberRepository;
        private readonly EventRepository _eventRepository;
        private readonly BookRepository _bookRepository;

        public LibraryForm()
        {
            InitializeComponent();
            string connectionString =
                "Data Source=(local);Initial Catalog=BooksLibrary_db;Integrated Security=True;Encrypt=False";

            _memberRepository = new MemberRepository(connectionString);
            _eventRepository = new EventRepository(connectionString);
            _bookRepository = new BookRepository(connectionString);
            CboEvents.DropDown += CboEvents_DropDown;
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            string email = TxtEmail.Text;
            string password = TxtPassword.Text;

            var memberInfo = _memberRepository.VerifyMember(email, password);

            if (memberInfo != null)
            {
                MessageBox.Show($"Welcome {memberInfo.FirstName}!");
            }
            else
            {
                MessageBox.Show("Login failed. Please check your email and password.");
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void CboEvents_DropDown(object sender, EventArgs e)
        {


            CboEvents.DataSource = _eventRepository.GetAll();
            CboEvents.DisplayMember = "EventDisplay";
            CboEvents.ValueMember = "Id";

        }

        private void BtnEventSignIn_Click(object sender, EventArgs e)
        {
            string email = TxtEventEmail.Text;
            string password = TxtEventPassword.Text;

            var memberInfo = _memberRepository.VerifyMember(email, password);

            if (memberInfo == null)
            {
                MessageBox.Show("Incorrect email or password. Please check your email and password.");
                return;
            }

            long memberId = memberInfo.Id;


            Event selectedEvent = CboEvents.SelectedItem as Event;

            if (selectedEvent == null)
            {
                MessageBox.Show("Please select an event.");
                return;
            }

            long eventId = selectedEvent.Id;

            bool registrationResult = _eventRepository.SignForEvent(memberId, eventId);

            if (registrationResult)
            {
                MessageBox.Show($"Welcome {memberInfo.FirstName}! Registration successful!");
            }

            else
            {
                MessageBox.Show("Registration failed. You have already signed for this event.");
            }
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {

            DgvBooks.AutoGenerateColumns = false;

            DgvBooks.DataSource = _bookRepository.GetAll();

            DgvBooks.Columns.Add("Title", "Title");
            DgvBooks.Columns["Title"].DataPropertyName = "Title";

            DgvBooks.Columns.Add("Author", "Author");
            DgvBooks.Columns["Author"].DataPropertyName = "Author";

            DgvBooks.Columns.Add("BuyingPrice", "Buying price");
            DgvBooks.Columns["BuyingPrice"].DataPropertyName = "BuyingPrice";
            DgvBooks.Columns["BuyingPrice"].DefaultCellStyle.Format = "C";


            DgvBooks.Columns.Add("RentingPrice", "Renting price");
            DgvBooks.Columns["RentingPrice"].DataPropertyName = "RentingPrice";
            DgvBooks.Columns["RentingPrice"].DefaultCellStyle.Format = "C";

        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            ConfirmationMessage("Buy");
        }

        private void BtnRent_Click(object sender, EventArgs e)
        {
            ConfirmationMessage("Rent");
        }

        private void ConfirmationMessage(string action)
        {
            DataGridViewCell selectedCell = DgvBooks.SelectedCells.Count > 0 ? DgvBooks.SelectedCells[0] : null;

            if (selectedCell != null)
            {
                DataGridViewRow selectedRow = DgvBooks.Rows[selectedCell.RowIndex];
                string bookTitle = selectedRow.Cells["Title"].Value.ToString();

                string confirmationMessage = $"You have successfully {action.ToLower()}ed the book: {bookTitle}";
                MessageBox.Show(confirmationMessage, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a book first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}







