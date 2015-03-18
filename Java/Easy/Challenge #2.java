// This is an Ideal Gas Law Calculator

 public static void main(String[] args){
        float R = 8.3145f;
        float n, v, t, p;
        String answer, units;

        Scanner scan = new Scanner(System.in);

        System.out.println("Ideal Gas law calculator!");
        System.out.println("What do you want to solve for? Moles = n, Volume = v, Temperature = t, Pressure = p");

        answer = scan.nextLine();

        if(answer.equalsIgnoreCase("n")){

            System.out.println("What is the volume?");
            v = Float.parseFloat(scan.nextLine());

            System.out.println("What units are these in? (mL or L only)");
            units = scan.nextLine();
            if(units.equalsIgnoreCase("ml")){
                v = v/1000;
            }

            System.out.println("What is the Temperature?");
            t = Float.parseFloat(scan.nextLine());

            System.out.println("What units are these in? (C or K only)");
            units = scan.nextLine();
            if(units.equalsIgnoreCase("C")){
                t = t + 273;
            }

            System.out.println("What is the Pressure?");
            p = Float.parseFloat(scan.nextLine());

            System.out.println("What units are these in? (kPa, Pa, mmHG, or atm)");
            units = scan.nextLine();
            if(units.equalsIgnoreCase("kPa")){
                p = (float) (p / 101.325);
            }
            else if(units.equalsIgnoreCase("Pa")){
                p = (float) (p / 101325);
            }
            else if(units.equalsIgnoreCase("mmHg")){
                p = (float) (p / 760);
            }

            n = (p*v)/(R*t);

            System.out.println("There are " + n + " moles!");


        }
        else if(answer.equalsIgnoreCase("v")){

            System.out.println("How many moles? (No scientific notation!)");
            n = Float.parseFloat(scan.nextLine());

            System.out.println("What is the Temperature?");
            t = Float.parseFloat(scan.nextLine());

            System.out.println("What units are these in? (C or K only)");
            units = scan.nextLine();
            if(units.equalsIgnoreCase("C")){
                t = t + 273;
            }

            System.out.println("What is the Pressure?");
            p = Float.parseFloat(scan.nextLine());

            System.out.println("What units are these in? (kPa, Pa, mmHG, or atm)");
            units = scan.nextLine();
            if(units.equalsIgnoreCase("kPa")){
                p = (float) (p / 101.325);
            }
            else if(units.equalsIgnoreCase("Pa")){
                p = (float) (p / 101325);
            }
            else if(units.equalsIgnoreCase("mmHg")){
                p = (float) (p / 760);
            }

            v = (n*R*t) / p;
            System.out.println("There are " + v + " Liters!");

        }
        else if(answer.equalsIgnoreCase("t")){

            System.out.println("How many moles? (No scientific notation!)");
            n = Float.parseFloat(scan.nextLine());

            System.out.println("What is the volume?");
            v = Float.parseFloat(scan.nextLine());

            System.out.println("What units are these in? (mL or L only)");
            units = scan.nextLine();
            if(units.equalsIgnoreCase("ml")){
                v = v/1000;
            }

            System.out.println("What is the Pressure?");
            p = Float.parseFloat(scan.nextLine());

            System.out.println("What units are these in? (kPa, Pa, mmHG, or atm)");
            units = scan.nextLine();
            if(units.equalsIgnoreCase("kPa")){
                p = (float) (p / 101.325);
            }
            else if(units.equalsIgnoreCase("Pa")){
                p = (float) (p / 101325);
            }
            else if(units.equalsIgnoreCase("mmHg")){
                p = (float) (p / 760);
            }

            t = ((p*v)/(n*R)) - 273;
            System.out.println("The temp is " + t + " degrees C!");

        }
        else if(answer.equalsIgnoreCase("p")){

            System.out.println("How many moles? (No scientific notation!)");
            n = Float.parseFloat(scan.nextLine());

            System.out.println("What is the volume?");
            v = Float.parseFloat(scan.nextLine());

            System.out.println("What units are these in? (mL or L only)");
            units = scan.nextLine();
            if(units.equalsIgnoreCase("ml")){
                v = v/1000;
            }

            System.out.println("What is the Temperature?");
            t = Float.parseFloat(scan.nextLine());

            System.out.println("What units are these in? (C or K only)");
            units = scan.nextLine();
            if(units.equalsIgnoreCase("C")){
                t = t + 273;
            }

            p = (n*R*t)/(v);
            System.out.println("The pressure is " + t + " atm!");

        }
        else{
            System.out.println("Invalid Entry. =[");

        }
    }