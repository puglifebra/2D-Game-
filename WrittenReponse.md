# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

A person would run my program to see a turret shoot at an enemy, this is for entertainment. 

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

The video demonstrates that my program has a turret that follow targets, then proceed to shoot them with a bullet, resulting in the enemy disappearing. 

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program accepts the user's clicking of the play button, outputting the enemies spawning in waves, and the turret shooting at the enemies. 

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
    public static Transform[] InitWayPoints(Waypoints waypoints)
    {
        if (waypoints == null) throw new System.Exception("Cannot process null waypoints");
        points = new Transform[waypoints.transform.childCount];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = waypoints.transform.GetChild(i);
        }
        return points;
    }
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in "waypoints" 

### 3b iv.

Describes what the data contained in the list represents in your program

The list represents all the positions that my enemy must interact with, creating a path for the enemy. 

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

My list contains 12 points, this could be written with 12 if . else if statements. 
This list manages complexity by allowing each point being able to be changed easily, instead of hard coding the location of each point, 
we can change the location via drag and drop.

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static Transform[] InitWayPoints(Waypoints waypoints)
    {
        if (waypoints == null) throw new System.Exception("Cannot process null waypoints");
        points = new Transform[waypoints.transform.childCount];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = waypoints.transform.GetChild(i);
        }
        return points;
    }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
void GetNextWaypoint()
    {
        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

// If the wave point is trying to go to one not existing 
// Then Destroy the Enemy 
// The wave point index will increase by one 
// The target is going to be the new wave point that is given from above code
// This is the main functionality of my program so that the enemies go along the right path, and cause the game to not work properly

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

/// If the waypoints are not near, the program will say "Cannot process null waypoints"
/// Then the code will identify the nearest point that is next in the path
/// If the point the enemy was going to is 0
/// The new point is then selected, and the enemy will move to that new point 
/// Method will repeat until it reaches the end

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

InitWayPoints(null)

Second call:

InitWayPoints(waypoints)

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
This test that the method fails when the input is null by throwing an exception.

Condition(s) tested by the second call:

This test that the method runs when the input is not null. 

### 3d iii.

Result of the first call:

The result is an exception is thrown

Result of the second call:

The enemy will head to the next point in hte given order of waypoints. 