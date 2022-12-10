using Raylib_cs;
namespace fo_the_game{
    class game{
        public static void Main(){
            map stage = new map();
            pikmin plyr = new pikmin();
            collision_class clsn = new collision_class();
            plyr.player_init();
            List<spike_class> spkelst = new List<spike_class>();
            stage.mapmaker();
            Raylib.InitWindow(1200, 800, "fo_the_game");
            Raylib.SetTargetFPS(60);
            int counter = 0;
            Raylib.InitAudioDevice();
            int x = 1;
            while(!Raylib.WindowShouldClose()){
                counter += x;
                Raylib.BeginDrawing();
                Raylib.ClearBackground(stage.getbackground());
                Raylib.DrawText(counter.ToString(), 100, 100, 45, Color.ORANGE);
                stage.makesidbar(0, 0, 450, 800, stage.getsidebarcolor());
                stage.makesidbar(750, 0, 450, 800, stage.getsidebarcolor());
                if(counter % 363 == 0){
                    x = x + 1;
                    spike_class spke = new spike_class();
                    spke.spawnspike();
                    spkelst.Add(spke);
                }
                Raylib.DrawRectangle(plyr.getx1(), plyr.gety(), plyr.getwidth(), plyr.getlength(), plyr.getcolor());
                Raylib.DrawRectangle(plyr.getx2(), plyr.gety(), plyr.getwidth(), plyr.getlength(), plyr.getcolor());
                if(Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)){
                    plyr.moveout();
                }
                else{
                    plyr.movein();
                }
                for(int i = 0; i < spkelst.Count(); i++){
                    spkelst[i].movedown();
                    Raylib.DrawRectangle(spkelst[i].getx(), spkelst[i].gety(), spkelst[i].getwidth(), spkelst[i].getlength(), spkelst[i].getcolor());
                    if(spkelst[i].gety() > 800){
                        plyr.scorefive();
                    }
                    if(clsn.collision(plyr, spkelst[i])){
                        plyr.goblack();
                        Raylib.DrawText("Game Over", 500, 300, 100, Color.GOLD);
                    }
                }
                
                Raylib.EndDrawing();
            }
        }
    }
    
}