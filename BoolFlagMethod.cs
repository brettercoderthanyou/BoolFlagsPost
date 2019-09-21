    public class MotorService
    {
        public void RotateMotor(double speed, bool isClockwise)
        {
            //SOME ARG VALIDATION 
            if (speed <= 0)
                throw new ArgumentOutOfRangeException("speed must be greater than zero");
            //CONVERT SPEED TO WHATEVER SPECIAL UNITS
            double convertedSpeed = speed * 1000 / 3;
            //CONDITIONALLY ROTATE
            if (isClockwise)
            {
                SendRotateClockwiseCommand(convertedSpeed);
            }
            else
            {
                SendRotateCounterClockwiseCommand(convertedSpeed);
            }
            //MORE LOGIC...
        }

        protected void SendRotateClockwiseCommand(double speed)
        {
            Console.WriteLine("Rotating clockwise at speed: " + speed);
        }

        protected void SendRotateCounterClockwiseCommand(double speed)
        {
            Console.WriteLine("Rotating counter clockwise at speed: " + speed);
        }

        protected void RotateMotorHelper(double speed, Action<double> rotateFn)
        {
            //SOME ARG VALIDATION 
            if (speed <= 0)
                throw new ArgumentOutOfRangeException("speed must be greater than zero");
            //CONVERT SPEED TO WHATEVER SPECIAL UNITS
            double convertedSpeed = speed * 1000 / 3;
            //JUST INVOKE SUPPLIED LOGIC
            rotateFn(convertedSpeed);
        }

        protected void RotateMotorClockwise(double speed)
        {
            RotateMotorHelper(speed, SendRotateClockwiseCommand);
        }

        protected void RotateMotorCounterClockwise(double speed)
        {
            RotateMotorHelper(speed, SendRotateCounterClockwiseCommand);
        }
    }