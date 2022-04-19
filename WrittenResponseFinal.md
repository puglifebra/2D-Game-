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

The video demonstrates that my program has a turret that follow targets, then proceed to shoot them with a bullet, resulting in the enemy disappearing and money increasing at the end of the wave.

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
void SpawnEnemy ()
    {
        enemies.Add(Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation).gameObject.GetComponent<Enemy>());
    }
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
    public int GetMoney(List<Enemy> enemies)
    {
        if (enemies == null) throw new System.Exception("Cannot Process Null Objects");
        foreach (Enemy e in enemies)
        {
            if(e.isDestroyed)
            {
                Money = Money + 5;
                Destroy(e);
            }
        }
        return Money;
    }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable enemies

### 3b iv.

Describes what the data contained in the list represents in your program

The data stored is all the enemies that are spawned in the game 

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

It would be difficult to write code that says when each clone is dead, add a specific amount of money to the total amount. If that were to happen, I would need to write code that would have to specifically address every single enemy that is killed. 

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
    public int GetMoney(List<Enemy> enemies)
    {
        if (enemies == null) throw new System.Exception("Cannot Process Null Objects");
        foreach (Enemy e in enemies)
        {
            if(e.isDestroyed)
            {
                Money = Money + 5;
                Destroy(e);
            }
        }
        return Money;
    }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
    void Update()
    {
        text.text = $"Money: {Money}";
    }
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

When the method is called, it is supposed the update a text that displays the current amount of money the player has after every wave

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1. If there are no enemies, print "Cannot Process Null Objects"
2. Else See how many enemies there are 
3. For each enemy that is destroyed
4. Add 5 to money 
5. Finally, iterate through all the enemies that are in the list 

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

GetMoney(null);

Second call:
enemies is a list of enemies from the most recent wave, for example, a wave with 7 destroyed enemies 
GetMoney (enemies);

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
Testing to see if the program correctly validates the input into the method, by throwing an exception if the input is invalid 

Condition(s) tested by the second call:

Testing to see if enemies are properly removed from the game when destroyed, and increase the total money.

### 3d iii.

Result of the first call:

"Cannot Process Null Objects"

Result of the second call:

35 