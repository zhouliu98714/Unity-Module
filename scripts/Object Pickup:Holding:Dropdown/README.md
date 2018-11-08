* Introduction

This is a code designed to render pickup/holding/dropdown controls using mouse clicks.
When clicking the mouse - picking up the object;
When pressing the mouse after clicking - holding on to the object
When releasing the mouse - dropping down the object


* Requirements
Needs to be placed within the object to be picked up.
The code has three public variables, all of which can be set manually(dragging).
- First, "item" needs to be the object itself
- Second, "Temp Parent" and "Guide" are both the player. "Guide" is a child to "Temp Parent" where we perform updated transformations. 

- Required hierarchy of the player:
In my case, 
    - "shopping cart" which is responsible for movement controls.
       - Under the "shopping cart", it is the "first person character" designed to be invisible) which stores the camera so it's convenient to rotate the camera as for now (ROTATION of the player will be implemented in the future). 
	 - Under the "first person character", we then have our "guide", which is both the "Temp Parent" and "Guide" of our public variables.


* Future Implementation
The code is not yet perfectly implemented. Will be optimized for necessary conveniences.