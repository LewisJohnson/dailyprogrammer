        Integer mult;
        Integer length;
       
        public static void main(String[] args) {
                Four scramble = new Four();
                scramble.prompt();
                scramble.generate();
        }
       
        public void prompt() {
                System.out.println("How many passwords would you like to generate?");
                Scanner user_input = new Scanner(System.in);
                mult = user_input.nextInt();
               
                System.out.println("How many characters per password?");
                length = user_input.nextInt();
                user_input.close();
        }
       
        public void generate() {
                char[] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
                StringBuilder encrypted = new StringBuilder();
                int j = 0;
                while (j < mult) {
                        for (int i = 0; i < length; i++) {
                                encrypted.append(alphabet[(int)(Math.random()*26)]);
                                //System.out.println(encrypted);
                                //System.out.println(alphabet[(int)(Math.random()*26)]);
                        }
                        System.out.println(encrypted);
                        encrypted.delete(0, encrypted.length()-1);
                        j++;
                }
        }