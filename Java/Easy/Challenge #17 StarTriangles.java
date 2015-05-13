 public static void main(String[] args) {
 
                Scanner s = new Scanner(System.in);
                out.println("What height would you like the  triangle?");
                int height = s.nextInt();
               
                growingTriangle(height);
                shrinkingTriangle(height);
               
 
        }
       
        private static void growingTriangle(int h){
                for (int i=0; i<h; i++){
                        for(int j=1; j<=Math.pow(2, i); j++){
                                out.printf("@");
                        }
                        out.println();
                }
        }
       
        private static void shrinkingTriangle(int h){
                for (int i=h-1; i>=0; i--){
                        for(int j=1; j<=Math.pow(2, i); j++){
                                out.printf("@");
                        }
                        out.println();
                }
        }