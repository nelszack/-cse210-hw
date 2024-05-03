using System;
using System.Dynamic;

public class Fraction{
    private int _num;
    private int _denom;

    public int getnum(){
        return _num;
    }
    public int getdenom(){
        return _denom;
    }

    public int setnum(int num){
        return _num=num;
    }
    public int setdenom(int denom){
       return  _denom= denom;
    }
    public string GetFractionString(){
        return  $"{_num}/{_denom}";
    } 
    public double GetDecimalString(){
        return (double)_num/(double)_denom;
    } 


    public Fraction(){
        _num=1;
        _denom=1;
    }
    public Fraction(int top){
        _num=top;
        _denom=1;
    }
    public Fraction(int top, int bottom){
        _num=top;
        _denom=bottom;
    }


}