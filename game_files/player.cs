using Raylib_cs;

class pikmin{
    private int x1;
    private int x2;
    private int y;
    private int points;
    private Color playercolor;
    public void player_init(){
        y = 600;
        x1 = 580;
        x2 = 600;
        playercolor = Color.RED;
    }
    public void goblack(){
        playercolor = Color.BLACK;
    }
    public int gety(){
        return y;
    }
    public int getx1(){
        return x1;
    }
    public int getx2(){
        return x2;
    }
    public int getlength(){
        return 20;
    }
    public int getwidth(){
        return 20;
    }
    public Color getcolor(){
        return playercolor;
    }
    public int getpoints(){
        return points;
    }
    public void scoreone(){
        points += 1;
    }
    public void scoretwo(){
        points += 2;
    }
    public void scorethree(){
        points += 3;
    }
    public void scorefive(){
        points += 5;
    }
    public void downone(){
        points -= 1;
    }
    public void downtwo(){
        points -= 2;
    }
    public void downthree(){
        points -= 3;
    }
    public void downfive(){
        points -= 5;
    }
    public void moveout(){
        if(x1 >= 450 && x2 <= 790){
            x1 -= 15;
            x2 += 15;
        }
    }
    public void movein(){
        if(x1 <= 580 || x2 >= 600){
            x1 += 1;
            x2 -= 1;
        }
    }
}
