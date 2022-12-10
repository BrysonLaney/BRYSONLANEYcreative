using Raylib_cs;
class spike_class{
    private int x;
    private int y;
    private int width;
    private int length;
    private Color spikecolor;
    Random rndm = new Random();
    public void spawnspike(){
        x = 500;
        width = 200;
        length = 125;
        spikecolor = Color.GREEN;
    }
    public void movedown(){
        y += 1;
    }
    public int gety(){
        return y;
    }
    public int getx(){
        return x;
    }
    public int getwidth(){
        return width;
    }
    public int getlength(){
        return length;
    }
    public Color getcolor(){
        return spikecolor;
    }

}