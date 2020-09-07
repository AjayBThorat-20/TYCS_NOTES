import java.util.Scanner;

public class Vernam {

    String encrypt(String str, String pad) {
        String encrypted = "";
        for (int i = 0; i < str.length(); i++) {
            int c = str.charAt(i);
            int p = pad.charAt(i);
            c = (c + p);
            if (c > 'Z') {
            	
                c = c%26;
                c = c+65;
            }
            encrypted += (char) c;
        }
        return encrypted;
    }

    String decrypt(String str, String pad) {
        String decrypted = "";
        for (int i = 0; i < str.length(); i++) {
            int c = str.charAt(i);
            int p = pad.charAt(i);
            c = (c - p)+26;
            if (c < 'A') {
                c = (c%26);
                c = c+65;
            }
           
            
//             if (c > 'Z') {
//                c = c - 26;
//            }          
//            System.out.println("c :" + c);
            decrypted += (char) c;
        }
        return decrypted;
    }

    public static void main(String[] args) {
    	System.out.println("performed by krunal 713");
        System.out.println("----*--Encrypting string using Vernam Cipher--*----");
        Vernam v = new Vernam();
        Scanner s = new Scanner(System.in);
        System.out.println("Input Data in Uppercase to encypt:");
        String str = s.nextLine();
        System.out.println("Input the Pad in Uppercase");
        String pad = s.nextLine();
        String encrypted = v.encrypt(str, pad);
        System.out.println("Encrypted Data :" + encrypted);
        String decrypted = v.decrypt(encrypted, pad);
        System.out.println("Decrypted Data:" + decrypted);
    }

}
