public static void main(String[] args) {
        int bottles = 99;

        while(bottles > 1) {
            System.out.print(bottles + " bottles of beer on the wall, " + bottles + " bottles of beer. ");
            System.out.print("You take one down, pass it around, " + (bottles - 1) + " bottles of beer on the wall. ");
            bottles--;
        }

        System.out.print(bottles + " bottle of beer on the wall, " + bottles + " bottle of beer. ");
        System.out.print("You take one down, pass it around, " + (bottles - 1) + " bottles of beer on the wall.");
    }
}