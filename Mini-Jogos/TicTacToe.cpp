/*Part of this program was taken from http://cboard.cprogramming.com/c-programming/148241-tic-tac-toe-opengl.html */

/* Program that draws a tic-tac-toe grid
 
   It also registers to receive, and responds to,
   mouse events                                   */
#define _USE_MATH_DEFINES

#include <math.h>
#include <stdlib.h>
#include <stdio.h>
#include <GL/glut.h>
 
#define INITIALWIDTH 500
#define INITIALHEIGHT 500

int row = 0, col = 0;
int matrix[3][3];
int scrWidth = INITIALWIDTH, scrHeight = INITIALHEIGHT;   /* Initial screen size */
int fifthWidth = INITIALWIDTH/5, fifthHeight = INITIALHEIGHT/5;
int thrice = (500 - (fifthHeight*2))/3;
 
void myinit( );          /* <- Functions written by the programmer to */
void display( );         /* ... produce the graphics they desire.     */
//void reshape(int, int);  /* ... myinit( ) is called once. Display( )  */
                         /* ... and reshape( ) are called as needed.  */
void grid( );            /* ... grid( ) draws tic-tac-toe grid and is */
                         /* ... called by display                     */
void mouse(int, int, int, int);
                         /* ... mouse( ) is called when mouse events  */
                         /* ... occur                                 */
void drawCircle(int, int);
void drawX(int, int);
 
/* Function to initialize OpenGL parameters and
   prepare for drawing as the programmer sees fit.  */
void myinit( )
{
	for (int i=0; i<3; i++){
		for (int j=0; j<3; j++){
			matrix[i][j] = 0;
		}
	}
  glClearColor(1.,1.,1.,1.);         /* white background */
  glColor3f(0.,0.,0.);               /* black foreground */
  glShadeModel(GL_FLAT);
  /* set up viewing scrWidth x scrHeight window with origin shifted
     up and to the right 25 pixels.                                 */
  glViewport(0,0,scrWidth,scrHeight);
  glMatrixMode(GL_PROJECTION);
  glLoadIdentity( );
             /* Establish left-right and bottom-top clipping planes */
             /* ... shifted to create an "empty zone" around grid   */
  gluOrtho2D(0.0,(GLdouble)scrWidth,(GLdouble)scrHeight,0.0);
  glMatrixMode(GL_MODELVIEW);
}
                   
/* Function registered with OpenGL for producing the graphics */
/*       This is the function you want to modify to customize */
/*       the drawing your program does.                       */
/*                                                            */
/*       Notice that it can call new, additional functions    */
/*       you write to modularize your code.                   */
void display( )
{
  glClear(GL_COLOR_BUFFER_BIT);
                  
  glLineWidth(3.0);   /* Wide line-width for board grid */
  glBegin(GL_LINES);  /* Begin drawing wide lines       */
                  
  grid( );            /* Draw tic-tac-toe grid          */
 
  glEnd( );
                  
  glLineWidth(1.0);   /* Narrow lines for X's and O's   */
  glBegin(GL_LINES);  /* Begin drawing narrow lines     */
                  
  glEnd( );               
  glFlush( );
}

void displayX( )
{                  
  glLineWidth(3.0);   /* Wide line-width for board grid */
  glBegin(GL_LINES);  /* Begin drawing wide lines       */
                  
  grid( );            /* Draw tic-tac-toe grid          */

  drawX(row, col);
 
  glEnd( );
                  
  glLineWidth(1.0);   /* Narrow lines for X's and O's   */
  glBegin(GL_LINES);  /* Begin drawing narrow lines     */
                  
  glEnd( );               
  glFlush( );
}
 
/* Draw the tic-tac-toe grid lines                    */
/* ... Called by display( ) to allow display( ) to be
   ... more succinct.                                 */
void grid( )
{
   
  glVertex2i(2*fifthWidth,fifthHeight);
  glVertex2i(2*fifthWidth,4*fifthHeight);
  glVertex2i(3*fifthWidth,fifthHeight);
  glVertex2i(3*fifthWidth,4*fifthHeight);
 
  glVertex2i(fifthWidth,2*fifthHeight);
  glVertex2i(4*fifthWidth,2*fifthHeight);
  glVertex2i(fifthWidth,3*fifthHeight);
  glVertex2i(4*fifthWidth,3*fifthHeight);
 
}

void drawX(int row, int col){

	glVertex2i((fifthWidth +10) + (thrice * col), (fifthHeight +10) + (thrice * row));
	glVertex2i((fifthWidth*2 -10) + (thrice * col), (fifthWidth*2 -10) + (thrice * row));

	glVertex2i((fifthWidth*2 -10) + (thrice * col), (fifthHeight +10) + (thrice * row));
	glVertex2i((fifthWidth +10) + (thrice * col), (fifthWidth*2 -10) + (thrice * row));

}
 
void mouse(int button, int state, int x, int y)
{
  if(button == GLUT_LEFT_BUTTON && state == GLUT_UP){
     
    if(fifthWidth < x && x < fifthWidth*2)
      col = 0;
    else if(fifthWidth*2 < x && x < fifthWidth*3)
      col = 1;
    else if(fifthWidth*3 < x && x < fifthWidth*4)
      col = 2;
       
    if(col > -1 && fifthHeight < y && y < fifthHeight*2)
      row = 0;
    else if(fifthHeight*2 < y && y < fifthHeight*3)
      row = 1;
    else if(fifthHeight*3 < y && y < fifthHeight*4)
      row = 2;
       
    if(col > -1 && row > -1){
		printf("Entrou...\n");
		if(matrix[row][col] == 0){
			printf("\nTb entrou...\n\n");
			displayX();
			matrix[row][col] = 1;
		}
    }
  }
    
  return;
}
 
///* Function called when the window is reshaped. */
//void reshape(int newScrWidth, int newScrHeight)
//{
//  scrHeight = newScrHeight;
//  scrWidth = newScrWidth;
//  fifthWidth = scrWidth/5;
//  fifthHeight = scrHeight/5;
//   
//  /* Restablish viewing scrWidth x scrHeight window */
//  glViewport(0,0,scrWidth,scrHeight);
//   
//  /* Restablish translation matrix place origin in lower-left */
//  glMatrixMode(GL_PROJECTION);      /* Matrix operations on projection matrix */
//  glLoadIdentity( );
//                       /* Establish left-right and bottom-top clipping planes */
//                       /* ... shifted to create an "empty zone" around grid   */
//  gluOrtho2D(0.0,(GLdouble)scrWidth,(GLdouble)scrHeight,0.0);
//  glMatrixMode(GL_MODELVIEW);       /* Matrix operations on model matrix      */
//  display2( );                       /* Redisplay the graphics/window          */
//}

/* Draw a circle with center (x,y) and radius r */
/*
   Draws a series of line segments to produce a
   circle.                                      */
void drawCircle(int row, int col)
{
	int cx = 150 + (thrice * col), cy = 150 + (thrice * row), r = 40;
  double angle;
  const int segments = 30;
 
  int x,y,oldX,oldY;
 
  oldX = cx + r;  /* first point */
  oldY = cy;
   
  for(angle = M_PI/segments; angle < 2*M_PI; angle += M_PI/segments){
    x = cx + cos(angle)*r; /* Compute next point to draw to */
    y = cy + sin(angle)*r;
    glVertex2i(oldX,oldY); /* Draw between previous point and  */
    glVertex2i(x,y);       /* ... new point                    */
 
    oldX=x;                /* Shift current point back to previous */
    oldY=y;
  }
}
 
int main(int argc, char** argv)
{
  glutInit(&argc,argv);                          /* These 1st four function   */
  glutInitDisplayMode (GLUT_SINGLE | GLUT_RGB);  /* ... calls are OpenGL/GLUT */
  glutInitWindowSize(scrWidth,scrHeight);        /* ... preparatory calls     */
  glutCreateWindow(argv[0]);
  
  glutDisplayFunc(displayX);
  glutDisplayFunc(display);    /* <- Registers the programmer's drawing code */
                               /* ... so that the graphics can be displayed  */
                               /* ... in the window.                         */
  glutMouseFunc(mouse);        /* <- Registers the programmer's mouse code   */
   
  myinit( );                   /* This is a local function to establish the   */
                               /* ... current state desired by the programmer.*/
   
  //glutReshapeFunc(reshape);     /* <- Registers the programmers drawing code  */
                                /* ... with OpenGL/GLUT so that if window is  */
                                /* ... reshaped, the graphics can be redrawn. */
                                 
  glutMainLoop( );       /* Starts the event-loop for the graphics environment. */
                   
  return 0;
}
 
