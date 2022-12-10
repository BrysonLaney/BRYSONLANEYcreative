class collision_class{
    public bool collision(pikmin plyr, spike_class spke){
        if(plyr.getx1() >= spke.getx() && plyr.getx2() <= (spke.getx() + 200 )&& plyr.gety() >= spke.gety() && plyr.gety() <= (spke.gety() + 125)){
            return true;
        }
        return false;
    }

}