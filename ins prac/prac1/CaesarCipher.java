/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package caesarcipher;

import java.util.Scanner;

public class CaesarCipher {

    
    public static void main(String[] args) {
        CaesarCipher c = new CaesarCipher();
        Scanner s = new Scanner(System.in);
        System.out.println("input data to encypt");
        String str = s.nextLine();
        System.out.println("input key : ");
        int key = s.nextInt();
        String encrypt = c.encrypt(str,key);
        System.out.println("ency data : "+ encrypt);
        String decrypted = c.decrypt(encrypt, key);
        System.out.println("decy data "+ decrypted);
        System.out.println("performed by rohan 703");
        
        
    }
    
    String encrypt(String str, int key){
        String encrypted = "";
        for(int i =0 ; i< str.length(); i++)
        {
            int c =str.charAt(i);
//            System.out.println("c:" + c);
            if(Character.isUpperCase(c)){
                c = (c+key);
//                System.out.println("c: " + c);
                if(c > 'Z'){
                    c = c-26;
                }
       
            }
            else
            {
                c= c+key;
//                System.out.println("c:" +c);
                if(c > 'z'){
                    c = c-26;
                }
                
            }
            encrypted += (char) c;
        }
        return encrypted;
      
        }
    String decrypt(String str, int key){
        String decrypted = "";
        for(int i =0 ; i< str.length(); i++)
        {
            int c =str.charAt(i);
//            System.out.println("c:" + c);
            if(Character.isUpperCase(c)){
                c = (c-key);
//                System.out.println("c: " + c);
                if(c < 'A'){
                    c = c+26;
                }
       
            }
            else
            {
                c= c-key;
//                System.out.println("c:" +c);
                if(c < 'a'){
                    c = c+26;
                }
                
            }
            decrypted += (char) c;
        }
        return decrypted;
      
        }
   
    
}
