Our game  started with designing all the characters, blocks, enimies and obstacles. Each one was made on the application SketchBook. After that we sat down and
started creation of the mechanics. It all started with the PlayerController. We started by adding physics to our world and colliders to each block and the main character. Within
PlayerController we coded the characters movements in such a way that allowed the player to move left, right jump and double jump. The double jump is done by checking if the charater is
on the ground or not. If he is he could do his initial jump, then while in the air, if he was not grounded and hadn't already double jumped, he could double jump. We also coded in
that the character model would flip when it turned, creating the illusion of changing direction. This was down by transforming the character model and making all of its x and y
corridnated the opposite sing of what they currently are.

One of the more arguous things we made was a main menu for our game, that was followed by a Personality quiz to determine which residential college you should be in. While we did get the
quiz to work, designing all fourteen characters was simply not possible on our time limit. So, with our bias in mind, we chose to create the two nearest and dearest to our hearts,
Silliman and Timothy Dwight. So while you cannot play as every college, you can still check in the console which college you were placed in by the quiz.

The next main script was the LevelManager, which controlled the players death. Essentially, when the character's collider box hit that of an obstacle or enemy, causing it to die, the character
model would be destroyed temporarily, a particle effect would be played, and then the character would be moved back to the latest checkpoint. Another Particle effect would be played and the
character would reappear. We created a delay between the when he dies and when he respawns, to make the particle effects more vissible and make the transition look smoother. The tricky part was
getting the character to actually stop, because even though his model disappeared, his colliders would continue moving and the camera would follow it as it fell off the map or when and collected
coins beyond the spikes it just died on, all during the delay.

Next in the list was creating checkpoints. For this we simply created invisible colliders, and everytime the player walked through them, it would update to be the current check point.
After that the LevelManager would take care of the rest and respawn the player there.

Next we set off the animate our characters. This required us draw and test each frame of the motion we wanted to create. After a few tries we finally got it to look smooth and like the player
was really walking and jumping. Next we had to set up the animator, so the character knew when to do which animation. So we set the chracter to be moving when his speed was greater than
30 and idle when his speed was less then 30. Then we had to check if he was on the gorund or not, so we borrowed from our PlayerController, and took the onGround variable to do that.
Once we had all the conenctions set up set set up the charater flipping part, which made the character look like it turns around.

We added some simple particle effects to make the deaths and respawns a bit more interesting. This required us to make some edits of the player controller, telling the game to play them
at the location of the player, one playing as he dies and one playing as he respawns. The next tricky bit was to delete those particle effects after they had finished playing, because
otherwise, while they would be visible they would still be saved and clogging up memory, so we developed the ParticleDestroyer script that destroys the plarticle once it is down playing
and if it becomes invisble.

Points, being a crucial part of any good game, were next on the TODO list. First we made the ScoreManager that would display the score as it was updated throughout the course of a game.
We made avariable called score, and everytime the player ran into a Paw(Handsome Dan's Paws), the paw was destroyed and points were added to the score, updating it real time as the player
plays the game. We then made it so that each time you die, you lose 25 points, half of the 50 you gain from each paw.

As every CS50 student knows, PSET's are to be feared. With this in mind we created an enemy model of a disastrous Pset grade. These enemies however have a mind of their own. We gave them
the ability to walk back and forth with no player input, and made sure they would turn around at walls and at the edge of platforms. We had add a collider box in front of the Psets,
then constantly check if they were ouching a wall. If they weren't the would just keep walking forwards normally. If they did touch a wall or reach they edge of a platform, the collider would
alert them and then would change direction, just by making their velocity in the x direction negative.

Giving the character health was a bit challenging because we had to revamp our whole death system. No longer could we allow things to just immediately kill the player, so we gave it hitpoints.
Similar to the way we did the score, we displayed the characters health on the top of the screen. It updates real time as the player runs into enemies. We displayed the variable health,
and then created a new script called DamagePlayer, whcih ensures that each time the player runs into an enemy, the player loses one of its three life points. Only when it reaches 0 does
the player die, giving him more of a chance against the evil Psets. The spikes however will still kill the player in one hit.

The last mechanic we added was creating knockback upon running into an enemy. Each time the player touches the Psets, his velocity is overwritten, and his is forcably moved in either direction,
depending on which side he hit the Pset from. After the short 0.2 seconds the player regains his movement. This was mainly implment so that the player couldn't get stuck between a wall
and a Pset, or even just be pushed around by a Pset.

Lastly we added some music to each level(Music from SoundCloud https://soundcloud.com/chunmeista/8bit-crossing-field-sword-art, https://soundcloud.com/surasshu/hot-jupiter),
creating more of a gaming feel. The only thing left to do was actually build the level. Witha bit of creativity and a lot of patience, we got it all to line and look like an actual
Video Game!
