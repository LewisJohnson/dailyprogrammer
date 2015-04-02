// Reddit user/Author: Broken_String

import java.util.Scanner;

public class PassWord {

public static void main(String[] args) {
    String userName = "SpaceMan";
    String userattempt;
    String passWord = "rocket";
    String passAttempt;
    Scanner pass = new Scanner(System.in);

    System.out.println("Please enter your username: ");
    userattempt = pass.nextLine();

    System.out.println("Please enter you password");
    passAttempt = pass.nextLine();

    if ((userattempt.equals(userName)) && (passAttempt.equals(passWord))) {
        System.out.println("Hello Mr.SpaceMan are you ready to return to Earth?");
    }else{
        System.out.println("Incorrect, access denied");
    }
}
}