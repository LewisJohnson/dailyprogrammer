public static void main(String[] args) { 
    Scanner input = new Scanner(System.in);
    System.out.println("Enter a phone number to validate: ");
    String number = input.readLine();
    isPhoneNumberValid(number);
    
}

public static boolean isPhoneNumberValid(String phoneNumber) {
        /*
        * Phone Number formats: (nnn)nnn-nnnn; nnnnnnnnnn; nnn-nnn-nnnn ^\\(? :
        * May start with an option "(" . (\\d{3}): Followed by 3 digits. \\)? :
        * May have an optional ")" [- ]? : May have an optional "-" after the
        * first 3 digits or after optional ) character. (\\d{3}) : Followed by
        * 3 digits. [- ]? : May have another optional "-" after numeric digits.
        * (\\d{4})$ : ends with four digits.
        *
        * Examples: Matches following phone numbers: (123)456-7890,
        * 123-456-7890, 1234567890, (123)-456-7890
        */
        // Initialize reg ex for phone number.
        String expression = "^\\(?(\\d{3})\\)?[- ]?(\\d{3})[- ]?(\\d{4})$";
        CharSequence inputStr = phoneNumber;
        Pattern pattern = Pattern.compile(expression);
        Matcher matcher = pattern.matcher(inputStr);
        return matcher.matches();
}