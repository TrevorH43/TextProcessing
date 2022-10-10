using System.ComponentModel;

namespace RVCUtilityLibrary
{
    public class RVCUserLib
    {
      
    }
    public static bool IsPasswordValid(string password, out string message)
    {
        bool isValid = false;
        message = "";
        int upperCount = 0, lowerCount = 0, numberCount = 0, specialCharacterCount = 0;

        const int MIN_LENGTH = 8;

        if (password.Length < MIN_LENGTH)
            message = $"Password must be at least {MIN_LENGTH} characters in length";
        else
        {
            // check for upper, lower, numbers, and special characters by incrementing a counter for each
            foreach (char passwordCharacter in password)
            {
                if (char.IsUpper(passwordCharacter)) upperCount++;
                if (char.IsLower(passwordCharacter)) lowerCount++;
                if (char.IsDigit(passwordCharacter)) numberCount++;
                if (!char.IsLetterOrDigit(passwordCharacter) &&
                    !char.IsWhiteSpace(passwordCharacter)) specialCharacterCount++;
            }

            // Now check to see if all counts are greater than 0, which means that the at least 1 requirement is satisfied
            if (upperCount > 0 && lowerCount > 0 && numberCount > 0 && specialCharacterCount > 0)
                isValid = true;
            else if (upperCount == 0)       // Missing Upper Case Letter
                message = "Password entry requires at least 1 uppercase letter.";
            else if (lowerCount == 0)       // Missing Lower Case Letter
                message = "Password entry requires at least 1 lowercase letter.";
            else if (numberCount == 0)      // Missing Digit, i.e., Number
                message = "Password entry requires at least 1 digit.";
            else                            // Missing Special Character
                message = "Password entry requires at least 1 special character.";
        }

        return isValid;

     

    }
}
