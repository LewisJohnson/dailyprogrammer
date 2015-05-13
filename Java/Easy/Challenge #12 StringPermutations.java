// Reddit user/Author: nothingatall544
public static void main(String[] args) {

    BufferedReader br = new BufferedReader(new InputStreamReader(System.in));   
    System.out.println("What string would you like permuted?");
    String perm = null;

    try {
        perm = br.readLine();
    } 
    catch (IOException e) {
        e.printStackTrace();
        System.exit(1);
    }

    System.out.println("perms");

    for (String x : perm(perm)){
        System.out.println(x);
    }
}

public static String[] perm(String perm) {

    String rest;
    ArrayList<String> inbetween = new ArrayList<String>();
    String[] ret = {perm};

    if (perm.length() > 1) {
        for (int i = 0; i < perm.length(); i++) {
            rest = perm.substring(0, i)+perm.substring(i+1, perm.length());
            for (String x:StringCon.perm(rest)){
                inbetween.add(perm.charAt(i)+x);
            }
        }
    } 

    else {
        return ret;
    }

    ret = inbetween.toArray(ret);
    return ret;
}