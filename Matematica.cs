using System.Globalization;
class Matematica{
    private float altura;
    private float raio;
    private float pi = 3.14f;
    private float bas;
    private int n1;
    private int n2;

    public  Matematica(float altura, float bas, int n1,float raio, int n2,float pi ){
        this.altura = altura;
        this.bas = bas;
        this.n1 = n1;
        this.n2 = n2;
        this.raio = raio;
        this.pi = 3.14f;
    }
    public float SetAltura(float altura){
        return this.altura = altura;

    }
    public float GetAltura(){
        return altura = alt;
        
    }
    public float SetBas(float bas){
        return this.bas = bas;
    }
    public float GetBas(){
        bas = b;
    }
    public int SetN1(int n1){
        return this.n1 = n1;
    }
    public float SetRaio(float r){
        return raio;
    }
    public float SetPi(float pi){
        return pi = 3.14f;
    }
    public float Quadrado(){
        return bas * altura;

    }
    public float Retangulo(){
        return bas * altura;
    }
    public float Triangulo(){
        return (bas * altura) / 2;

    }
    public float Circulo(){
        return pi * Math.Pow(raio, 2);
    }
    public int Tabuada(){
        for(int i = 0; i <= 10; i++){
            int res = n1 * i;
        }
    }
    
}