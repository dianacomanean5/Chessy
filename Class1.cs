using System;

public class Piece
{
    protected int x;
    protected int y;
    protected int color;
    Piece (int x,int y,int color){
        this.x=x;
        this.y=y;
        this.color=color;

    }
    public void setX(int x){
        this.x=x;
    }
    public int getX(){
        return x;
    }
   public void setY(int y){
       this.y=y;
   }
    public int getY(){
        return y;
    }

 public void setColor(int color){
     this.color=color;
 }
    public int getColor(){
        return color;
    }

	public  void muta (int dx,int dy)
	{
        x+ = dx;
        y+ = dy;
   
	}
     public void Afiseaza()
    {
        Console.WriteLine.(PictureBox);
    }

    public void Sterge()
    {

    }
}
