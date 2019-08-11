using System;

public static class Kata{
  public static int[] CountBy(int x,int n){
    int[] z=new int[n];
    while(n-->0){
      z[n]=x*(n+1);
    }
    return z;
  }
}
