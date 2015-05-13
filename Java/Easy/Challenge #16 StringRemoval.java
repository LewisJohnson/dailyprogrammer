// Reddit user/Author: turboemu
public static void main(String[] args) {
                Scanner s = new Scanner(System.in);
                System.out.println("What string do you want to remove letter from?");
                String input = s.nextLine();
                System.out.println("What do you want to remove?");
                String remove = s.nextLine();
                System.out.println(letterKiller(input, remove));
        }
       
        private static String letterKiller(String string, String remove){
                StringBuffer resultString = new StringBuffer("");
                for(int i=0; i<string.length(); i++){
                        for (int j= 0; j<remove.length();j++){
                                if(string.charAt(i)==remove.charAt(j)){
                                        break;
                                }else if(j==remove.length()-1){
                                        resultString.append(string.charAt(i));
                                }
                               
                        }
                       
                }
               
                return resultString.toString();
        }