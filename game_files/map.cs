using Raylib_cs;
class map{
    private Color background;
    private Color sidebar;
    private Color Pointcolor;
    public void mapmaker(){
        background = Color.SKYBLUE;
        sidebar = Color.BLUE;
        Pointcolor = Color.DARKGREEN;
    }
    public Color getbackground(){
        return background;
    }
    public Color getsidebarcolor(){
        return sidebar;
    }
    public Color getpointcolor(){
        return Pointcolor;
    }
    public void makesidbar(int x, int y, int width, int length, Color color){
        Raylib.DrawRectangle(x, y, width, length, color);
    }
}