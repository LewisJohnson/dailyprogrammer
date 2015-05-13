 public static void main (String[]args) {
        int dayOfMonth = 0, numMonth, totalDays = 0, answer;
        int[] Month = {31,28,31,30,31,30,31,31,30,31,30,31};
        Scanner input = new Scanner(System.in);
 
        System.out.print("What month is it (number): ");
        numMonth = input.nextInt();
 
        System.out.print("\nWhat Day of the month is it: ");
        dayOfMonth = input.nextInt();
 
        System.out.print("\nIs it a leap year (0 for yes, 1 for no): ");
        answer = input.nextInt();
 
        if(answer == 0)
                Month[1] = Month[1] + 1;
 
        for(int i = 0; i < numMonth - 1; i++)
                totalDays = totalDays + Month[i];
 
        totalDays = totalDays + dayOfMonth;
 
        System.out.print("\n\nTotal Days: " + totalDays);
    }