using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;
using Tao.FreeGlut;

namespace trabalho1bim
{
    //descriçao do trabalho
    /*(inicio de um)Jogo de nave
     1-uma nave feita com gltriangres e glquads
     2-O cenarios feitos com glpointers randomicos
     3-obstaculos feitos com polignos que se movem com translated e rotate com timer
     4-controle da nave no wasd
    */



    //variaveis asteroide
   
    class Program
    {
        //variaveis asteroide
        static float ax = 0.0f;
        static float ay = 0.0f;
        static float ax2 = 0.0f;
        static float ay2 = 0.0f;
        static float xstep = 0.002f;
        static float ystep = 0.002f;
 
        //variaveis nave
        static float nx = 0.0f;
        static float ny = 0.0f;

        //variavel do cenario
        static float cx = 0.0f;
        static float cy = 0.0f;



        static void nave()//nave ainda nao desenhada
        {
            Gl.glPushMatrix();//salva para mover so estes objetos
            Gl.glTranslatef(nx, ny, 0.0f);
            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glVertex2f(-0.05f, -0.9f);
                Gl.glVertex2f(0.05f, -0.9f);
                Gl.glVertex2f(0.05f, -0.75f);
                Gl.glVertex2f(-0.05f, -0.75f);
            Gl.glEnd();
            Gl.glBegin(Gl.GL_TRIANGLE_FAN);
                Gl.glVertex2f(-0.05f, -0.85f);
                Gl.glVertex2f(-0.05f, -0.75f);
                Gl.glVertex2f(-0.13f, -0.85f);
            Gl.glEnd();
            Gl.glBegin(Gl.GL_TRIANGLE_FAN);
                Gl.glVertex2f(0.05f, -0.85f);
                Gl.glVertex2f(0.05f, -0.75f);
                Gl.glVertex2f(0.13f, -0.85f);
            Gl.glEnd();
            Gl.glBegin(Gl.GL_TRIANGLE_FAN);
                Gl.glVertex2f(-0.05f, -0.75f);
                Gl.glVertex2f(0.05f, -0.75f);
                Gl.glVertex2f(0.0f, -0.6f);
            Gl.glEnd();
            Gl.glPopMatrix();//apaga da pilha

            Glut.glutSwapBuffers();
        }
        static void cenario()
        {
            Gl.glPushMatrix();//salva para mover so estes objetos
            Gl.glColor3f(0.0f, 0.5f, 0.9f);
            Gl.glPointSize(5);
            Gl.glTranslated(0.0f, cy, 0.0f);
            Gl.glBegin(Gl.GL_POINTS);
         
         
                Gl.glVertex2f(0.1f,0.2f);
            Gl.glVertex2f(0.5f, 0.2f);
            Gl.glVertex2f(0.4f, 0.7f);
            Gl.glVertex2f(0.3f, 0.1f);
            Gl.glVertex2f(0.5f, 0.8f);
            Gl.glVertex2f(0.6f, 0.2f);
            Gl.glVertex2f(-0.1f, 0.54f);
            Gl.glVertex2f(0.4f, -0.6f);
            Gl.glVertex2f(0.5f, -0.7f);
            Gl.glVertex2f(-0.43f, 0.123f);
            Gl.glVertex2f(-0.1f, -0.89f);
            Gl.glVertex2f(-0.21f, -0.2f);
            Gl.glVertex2f(0.1f, -0.33f);
            Gl.glVertex2f(-0.33f, 0.44f);
            Gl.glVertex2f(-0.1f, 0.2f);
            Gl.glVertex2f(-0.56f, 0.3f);
            Gl.glVertex2f(-0.66f, 0.4f);
            Gl.glVertex2f(-0.78f, 0.8f);
            Gl.glVertex2f(-0.34f, 0.4f);
            Gl.glVertex2f(-0.56f, -0.56f);
            Gl.glVertex2f(-0.76f, -0.73f);
            Gl.glVertex2f(-0.89f, -0.80f);
            Gl.glVertex2f(-0.99f, -0.30f);
            Gl.glVertex2f(-0.74f, -0.15f);
            Gl.glVertex2f(0.1f, 0.2f);
            Gl.glEnd();


            Gl.glPopMatrix();//apaga da pilha
            Glut.glutSwapBuffers();

        }

        //static void Estrelas()//nave ainda nao desenhada
        //{
        //    Gl.glPushMatrix();//salva para mover so estes objetos
        //    Gl.glColor3f(1.0f, 1.0f, 1.0f);
        //    Gl.glBegin(Gl.GL_LINE_LOOP);
        //        Gl.glVertex2f(-0.5f, 0.5f);
        //        Gl.glVertex2f(-0.6f, 0.4f);
        //        Gl.glVertex2f(-0.55f, 0.55f);
        //        Gl.glVertex2f(-0.52f, 0.4f);
        //        Gl.glVertex2f(-0.6f, 0.5f);
        //    Gl.glEnd();
            
        //    Gl.glPopMatrix();//apaga da pilha

        //    Glut.glutSwapBuffers();
        //}

        const float PI = 3.14f;
        static void asteroids()//asteroid ainda nao desenhado
        {
            float raio, x, y, pontos; 
            raio = 0.1f;
            pontos = (2 * PI) / 5;

            Gl.glPushMatrix();
            Gl.glTranslatef(0.5f, 0.6f, 0.0f);
            

            Gl.glPushMatrix();//salva para mover so estes objetos
            Gl.glTranslatef(ax, ay, 0.0f);
            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glRotatef(rot, 0.0f, 0.0f, 0.2f);
            Gl.glTranslatef(-0.5f, -0.6f, 0.0f);
            //Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            
            Gl.glBegin(Gl.GL_TRIANGLE_FAN);
            Gl.glColor3f(1.0f, 1.0f, 1.0f);
            Gl.glVertex2f(0.5f, 0.6f);
            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            for (float angulo = 0; angulo <= 2 * PI; angulo += pontos)
            {
                x = (float)(raio * Math.Cos(angulo) + 0.5f);
                y = (float)(raio * Math.Sin(angulo) + 0.6f);
                Gl.glVertex2f(x, y);
            }
            Gl.glEnd();
            Gl.glPopMatrix();//apaga da pilha

            Glut.glutSwapBuffers();

        }
      


        static void Desenha()//desenha os objeto na tela
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glLoadIdentity();
            cenario();
            nave();
       
            asteroids();
    
            
            Glut.glutSwapBuffers();
        }

        static float rot = 0.0f;        static void moverAsteroid(int value)//move o asteroid em time
        {
            // Muda a direção quando chega na borda esquerda ou direita
            if (ax > 0.5f || ax < -1.5f)
            {
                xstep = -xstep;
            

            }
            // Muda a direção quando chega na borda superior ou inferior
            if (ay <= -1.5f)
            {
                ay = 0.7f;
               
            }
         
            // Move o quadrado
            ax += xstep;
            ay -= ystep;
           
            cy -= 0.001f;
        

            if (cy <= -1.0f) { cy = 0.7f;}
         

            // Redesenha o quadrado com as novas coordenadas
            Glut.glutPostRedisplay();
            Glut.glutTimerFunc(1, moverAsteroid, 1);

            rot -= 1;// Velocidade do giro do asteroid
            // Redesenha o quadrado com as novas coordenadas
            //Glut.glutPostRedisplay();
            //Glut.glutTimerFunc(10, moverAsteroid, 1);
        }


        static void Teclasnave(int key, int x, int y)//setinhas para controlar
        {
            switch (key)
            {
                case Glut.GLUT_KEY_UP:
                    if (ny <= 0.9f)
                        ny += 0.05f;

                    break;
                case Glut.GLUT_KEY_DOWN:
                    if (ny >= -0.05f)
                        ny -= 0.05f;
                    break;
                case Glut.GLUT_KEY_LEFT:
                    if (nx >= -0.85f)
                        nx -= 0.05f;

                    break;
                case Glut.GLUT_KEY_RIGHT:
                    if (nx <= 0.8f)
                        nx += 0.05f;
                    break;
            }
            Glut.glutPostRedisplay();
        }





        static void Inicializa()
        {
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Gl.glClearColor(0.0f, 0.0f, 0.0f, 0.0f);
        }

        static void Main(string[] args)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_SINGLE | Glut.GLUT_RGB);
            Glut.glutInitWindowSize(600, 600);
            Glut.glutInitWindowPosition(100, 100);
            Glut.glutCreateWindow("Projeto");
            Inicializa();
            Glut.glutDisplayFunc(Desenha);
            Glut.glutSpecialFunc(Teclasnave);
            
            Glut.glutTimerFunc(300, moverAsteroid, 1);
            Glut.glutMainLoop();

        }
    }
}
