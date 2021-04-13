using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Resources;

namespace Chess
{
    public class ClassPiece
{
    protected int x;
    protected int y;
    protected int color;
    
   virtual public void Deseneaza(joc form)
    {
        PictureBox box = new PictureBox();
        box.Image = Properties.Resources.Picture1;
        box.Width = 50;
        box.Height = 53;
     
        box.Location = new Point(631, 414);
        box.Visible = true;



        form.Controls.Add(box);
    }
    
    
   public ClassPiece (int x,int y,int color){
        this.x=x;
        this.y=y;
        this.color=color;
    
}
 public  ClassPiece() {
       this.x = 0;
       this.y = 1;
       this.color = 1;
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

	}
}

