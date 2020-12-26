# GE_CA
Student Name: Zhimian Wu  

Student Number: D16123932  

Course Name: Game Engine 1  

Class Group: DT228  

# Project
A simulator of a small world in forest.

# Description of this project
This project is going create a virtual environment that a small forest include grass and flowers.

In this environment, weather will be simulated, like wind and it will change with times.

Users could explore and observe the scene in the small forest, include the sunset and sunrise.

# Instructions for use

User could move by typing "WASD" and mouse control the camera, "Space" bar is jump. Use mouse to control the camera. (be careful not fall from the edge of this small map)

To run this project, you might need to clone this Git repository.
If there is any texture that do not work you might need to download some Unity asset package from Unity Asset Store and import them into this project.
The Unity asset package links is in the **References** Part.

# How it works
In this project, I have add a day-night cycle which I learned from Internet. To add the simple day-night system to the project, need two light sources and put them in the relative position and add the rotation script, you can make a simple day-night cycle system.

Here is the code in Update() function of this script:
```
transform.RotateAround(Vector3.zero, Vector3.right, 2f * Time.deltaTime);
transform.LookAt(Vector3.zero);
```

About the player movement part I used a capsule as the player and put the main camera into it to make it like the First-person perspective. Thne I write two scripts, one for the camera and another for the player movement.

As for the camera, I used `GetAxis()` function to get the user mouse position and also add `xRotation` variable to limit the range of the player's viewing angle so that the viewing angle will not rotate excessively.

Here is the code of `GetAxis()`function and `xRotation`:
```
mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
```
Get the position of user mouse.

```
xRotation -= mouseY;
xRotation = Mathf.Clamp(xRotation,-70f,70f);
```
Limit the viewing range angle.

As for the player movement, I also used `GetAxis()` function to get the user keyboard input and store the data in a Vertor3 variable to control the character move direction. After add the jump behavior, gravity is added as well. Set the Terrain as the 'Ground Layer' and add a 'GroundCheck' function to check if player is on the ground so that player could jump.

`GetAxis()` function code:
```
horizontalMove = Input.GetAxis("Horizontal") * moveSpeed;
verticalMove = Input.GetAxis("Vertical") * moveSpeed;
```

Vector3 variable to control the character move direction:
```
private void Start()
{
  cc = GetComponent<CharacterController>();
}

private void Update()
{
  dir = transform.forward * verticalMove + transform.right * horizontalMove;
  cc.Move(dir * Time.deltaTime);
}
```

Gravity code:
```
velocity.y -= gravity * Time.deltaTime;
```

Ground Check function and jump function:
```
isGround = Physics.CheckSphere(groundCheck.position,checkRadius,groundLayer);

if(isGround && velocity.y < 0)
{
  velocity.y = -2f;
}

if(Input.GetButtonDown("Jump") && isGround)
{
  velocity.y = jumpSpeed;
}
```

# References
Video material:
- Unity 5 Tutorial - Day/Night Cycle
https://www.youtube.com/watch?v=DmhSWEJjphQ&t=644s

Unity Asset Package Used:
- Conifers [BOTD]
https://assetstore.unity.com/packages/3d/vegetation/trees/conifers-botd-142076
- Grass Flowers Pack Free
https://assetstore.unity.com/packages/2d/textures-materials/grass-flowers-pack-free-138810

# What I am most proud of in the assignment
I think the best part of this project is the player movement which include the camera control and player control.
User could use mouse to control the direction (camera) and press "WASD" to move in any direction and "Space" bar to jump (user keyboard input) and the addition of gravity system makes this project closer to the real world.
Including the creation and design of the terrain (although this small world is not perfect), the addition of trees and grass makes this project more perfect.

# Youtube Video Demo
[![Game Engine 1 CA Demo](https://res.cloudinary.com/marcomontalbano/image/upload/v1608939110/video_to_markdown/images/youtube--7A_97zPr-FM-c05b58ac6eb4c4700831b2b3070cd403.jpg)](https://www.youtube.com/watch?v=7A_97zPr-FM "Game Engine 1 CA Demo")

# Thanks for your watching!!!
