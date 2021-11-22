Welcome to Riley's Hands
Video Walkthrough - https://www.youtube.com/watch?v=DxKWq7z4Xao

How to Setup:

1) Import 'Riley's Hands' folder into Unity Assets folder.
2) Inside folder there are 5 sub-folders: Animation, Models, Scripts, Prefabs, and Photos.
3) Locate the Prefab folder.
4) Inside of the Prefab folder, there are 2 hands: RightHand, and LeftHand. Drag each hand to the respective hand controller as children. (Ex. LeftHand --> LeftHand Controller)
5) Locate the Scripts folder, inside there should be 2 scripts: Hand.cs, HandController.cs.
6) Drag the HandController.cs script to each hand controller. (Ex. HandController.cs --> LeftHand Controller)
7) On Each HandController there should be some type of interactor. (Ex. XR Direct Interactor) In the interactor's 'Select Entered' event make a new list element, and drag the hand that is attached as a child into it. (Ex. If LeftHand Controller --> Drag LeftHand). Then set the Function to: Hand.ToggleVisibility. Repeat this for the 'Select Exited' event as well on both hand controllers.
8) Your controllers should be animated now. :)

Note: If you have an existing hand model on the controller, you have to remove that.