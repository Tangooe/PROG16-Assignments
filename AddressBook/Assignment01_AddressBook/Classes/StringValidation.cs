using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AddressBook.Classes
{
    public class StringValidation
    {
        static Form1 addressBook = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        public static bool CheckValidation()
        {
            bool isFullNameOK = Letters(addressBook.txtFullName.Text);
            bool isAddressOk = LettersAndNumbers(addressBook.txtAddress.Text);
            bool isAreaCodeOK = Numbers(addressBook.txtAreaCode.Text);
            bool isCityOk = Letters(addressBook.txtCity.Text);
            bool isPhoneNumberOK = PhoneNumber(addressBook.txtPhone.Text);
            bool isEmailOK = Email(addressBook.txtEmail.Text);

            bool[] validationArray = new bool[]
            {
                isFullNameOK,
                isAddressOk,
                isAreaCodeOK,
                isCityOk,
                isPhoneNumberOK,
                isEmailOK
            };

            var textboxes = new TextBox[] 
            {
                addressBook.txtFullName,
                addressBook.txtAddress,
                addressBook.txtAreaCode,
                addressBook.txtCity,
                addressBook.txtPhone,
                addressBook.txtEmail
            };

            bool validationComplete = true;

            var i = 0;
            foreach (bool b in validationArray)
            {
                if (b == false)
                {
                    addressBook.errorProvider1.SetError(textboxes[i], "It looks like you've entered an inccorect input in this textbox");
                    validationComplete = false;
                }

                ++i;
            }

            return validationComplete;
        }

        private static bool Email(string email)
        {
            email = email.Trim();
            
            if ((email.Count(x => x == '@')) == 1 && (email[email.Length - 4] == '.' || email[email.Length - 3] == '.'))
            {
                if(email.IndexOf('@') >= 2 && email.LastIndexOf('.') - email.IndexOf('@') >= 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
        private static bool Numbers(string numbers)
        {
            if (Regex.IsMatch(numbers, @"^[\p{N}\s]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool PhoneNumber (string phoneNumber)
        {
            if (Regex.IsMatch(phoneNumber, @"^[\p{N}\s-]+$") && phoneNumber.Length >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool Letters(string letters)
        {
            if(Regex.IsMatch(letters, @"^[\p{L}\s]+$") )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool LettersAndNumbers(string text)
        {
            if (Regex.IsMatch(text, @"^[\p{L}\p{N}\s]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}