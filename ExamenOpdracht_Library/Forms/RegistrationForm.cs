using ExamenOpdracht_Library.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ExamenOpdracht_Library.Repositories;

namespace ExamenOpdracht_Library.Forms
{
    public partial class RegistrationForm : Form
    {
        private readonly MemberRepository _memberRepository;
        public RegistrationForm()
        {
            InitializeComponent();
            string connectionString = "Data Source=(local);Initial Catalog=BooksLibrary_db;Integrated Security=True;Encrypt=False";
            _memberRepository = new MemberRepository(connectionString);
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            
                string firstName = TxtFirstName.Text;
                string lastName = TxtLastName.Text;
                int age;

                if (!int.TryParse(TxtAge.Text, out age))
                {
                    MessageBox.Show("Please enter a valid age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string email = TxtEmail.Text;
                string password = TxtPassword.Text;

                var newMember = new Member
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Email = email,
                    Password = password
                };

                
                    if (_memberRepository.IsEmailAlreadyRegistered(email))
                    {
                        MessageBox.Show("This email address is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool registrationResult = _memberRepository.RegisterMember(newMember);

                    if (registrationResult)
                    {
                        MessageBox.Show("Member registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Member registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
        }
            
    }
}

