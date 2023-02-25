
class Shape
{
    public virtual int Area(){
        throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle:Shape{
    private int width;
    private int height;
    
    public int Width{
        get{
            return width;
        }
        set{
            if (value < 0){
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }
    
    public int Height{
        get{
            return height;
        }
        set{
            if (value < 0){
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }
    
    public override int Area(){
        return this.height * this.width;
    }
    
    public override string ToString(){
        return String.Format("[Rectangle] {0} / {1}", this.width, this.height);
    }
}

class Square:Rectangle{
    private int size;
    
    public int Size{
        get{
            return this.size;
        }
        set{
            if (value < 0){
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            base.Height = value;
            base.Width = value;
            this.size = value;
        }
    }
}