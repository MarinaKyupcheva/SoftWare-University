using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleSnake.GameObjects;

namespace SimpleSnake.GameObjects
{
    public class Snake
    {
        private Wall wall;
        private readonly Queue<Point> snakeElements;
        private const int snakeStartLength = 6;
        private readonly Food[] foods;
        private int nextLeftX;
        private int nextTopY;
        private const char snakeSymbol = '\u25CF';
        private int foodIndex;
        private const char emptySpaceSymbol = ' ';
        private int snakePoints;
        private int levelCounter;

        private bool isFoodSpawned; 
        public Snake(Wall wall)
        {
            this.wall = wall;
            this.snakeElements = new Queue<Point>();
            this.foods = new Food[3];
            this.foodIndex = RandomFoodNumber;
            this.isFoodSpawned = false;
            this.snakePoints = 6;
            this.levelCounter = 100;
            this.GetFoods();
            this.CreateSnake();
        }

        public int SnakePoints => this.snakePoints;
        public int SnakeLevel => this.levelCounter / 100;
        private int RandomFoodNumber =>
            new Random().Next(0, this.foods.Length);
        public bool IsMoving(Point direction)
        {
            Point currentSnakeHead = this.snakeElements.Last();
            GetNextPoint(direction, currentSnakeHead);

            bool IsPointOFSnake = this.snakeElements.Any(p => p.LeftX == this.nextLeftX && p.TopY == this.nextTopY);

            if (IsPointOFSnake)
            {
                return false;
            }

            Point newSnakeHead = new Point(this.nextLeftX, this.nextTopY);

            if (this.wall.IsPointOfWall(newSnakeHead))
            {
                return false;
            }

            this.snakeElements.Enqueue(newSnakeHead);
            newSnakeHead.Draw(snakeSymbol);

            if (!this.isFoodSpawned)
            {
                this.foods[foodIndex].SetRandomPosition(this.snakeElements);
                this.isFoodSpawned = true;
            }

            if (this.foods[foodIndex].IsFoodPoint(newSnakeHead))
            {
                this.Eat(direction, currentSnakeHead);
            }

            Point snakeTail = this.snakeElements.Dequeue();
            snakeTail.Draw(emptySpaceSymbol);

            this.levelCounter++;
            return true;
        }

        private void Eat(Point direction, Point currentSnakeHead)
        {
            int length = this.foods[foodIndex].FoodPoints;

            for (int i = 0; i < length; i++)
            {
                this.snakeElements.Enqueue(new Point(this.nextLeftX, this.nextTopY));
                GetNextPoint(direction, currentSnakeHead);
            }

            this.snakePoints += length;
            this.foodIndex = RandomFoodNumber;
            this.foods[foodIndex].SetRandomPosition(this.snakeElements);
           
        }
        private void GetNextPoint(Point direction, Point snakeHead)
        {
            this.nextLeftX = direction.LeftX + snakeHead.LeftX;
            this.nextTopY = direction.TopY + snakeHead.TopY;
        }
        private void CreateSnake()
        {
            for (int topY = 1; topY <= snakeStartLength; topY++)
            {
                this.snakeElements.Enqueue(new Point(2, topY));
            }
        }

        private void GetFoods()
        {
            this.foods[0] = new FoodHash(this.wall);
            this.foods[1] = new FoodDollar(this.wall);
            this.foods[2] = new FoodAsterisk(this.wall);
        } 
    }
}
