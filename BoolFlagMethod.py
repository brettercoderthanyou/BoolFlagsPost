def RotateMotor(speed, isClockwise):
    #SOME ARG VALIDATION
    if(speed <= 0):
        raise Exception("speed must be greater than zero")
    #CONVERT SPEED TO WHATEVER SPECIAL UNITS
    convertedSpeed = speed*1000/3
    #CONDITIONALLY ROTATE 
    if(isClockwise):
        SendRotateClockwiseCommand(convertedSpeed)
    else:
        SendRotateCounterClockwiseCommand(convertedSpeed)
    #MORE LOGIC...

def SendRotateClockwiseCommand(speed):
    print("Rotating clockwise at speed: ", speed)
    
def SendRotateCounterClockwiseCommand(speed):
    print("Rotating counter clockwise at speed: ", speed)

RotateMotor(100, False)

def RotateMotorHelper(speed, rotateFn):
    #SOME ARG VALIDATION
    if(speed <= 0):
        raise Exception("speed must be greater than zero")
    #CONVERT SPEED TO WHATEVER SPECIAL UNITS
    convertedSpeed = speed*1000/3
    #JUST INVOKE SUPPLIED LOGIC
    rotateFn(convertedSpeed)

def RotateMotorClockwise(speed):
    RotateMotorHelper(speed, SendRotateClockwiseCommand)

def RotateMotorCounterClockwise(speed):
    RotateMotorHelper(speed, SendRotateCounterClockwiseCommand)
