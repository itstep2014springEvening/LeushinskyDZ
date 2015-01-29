#ifndef COMPATIBILITY_H_INCLUDED
#define COMPATIBILITY_H_INCLUDED

#include <assert.h>


typedef enum _Direction {Up, Down, Right, Left, Mistake} Direction;
Direction getKey();


#if defined(WIN32) || defined(_WIN32) || defined(__WIN32) || defined(__WIN32__) \
 || defined(WIN64) || defined(_WIN64) || defined(__WIN64) || defined(__WIN64__)


#include <conio.h>
Direction getKey()
{
    getch();
      Direction direction = Mistake;
    int key = getch(), key1, key2;

    switch(key)
    {
        case 228	:
            direction = Left;
            break;

        case 235	:
            direction = Down;
            break;

        case 230	:
            direction = Up;
            break;

        case 162	:
            direction = Right;
            break;


                }
                return direction;
    }
void windowsClear();

void clear()
{
    windowsClear();
}

#define EMPTY_CELL " "
#define WALL_CELL "\xDB"
#define FOG_CELL "\xB0"
#define HERO_CELL "@"
#define M_CELL "&"

#elif defined(linux) || defined(__linux) || defined(__linux__) || defined(__gnu_linux)

#include <stdio.h>

int linuxGetch();


void linuxClear();

void clear()
{
    linuxClear();
}

#define EMPTY_CELL " "
#define WALL_CELL "\342\226\210"
#define FOG_CELL "\342\226\221"
#define HERO_CELL "@"
#define M_CELL "&"


#else
#error Not supporting OS
#endif // Os variant

#endif // COMPATIBILITY_H_INCLUDED
