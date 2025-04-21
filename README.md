# 🎮 Make Your First Unity Game – Beginner Friendly Guide

Welcome! 👋  
This is a **step-by-step tutorial** designed especially for **beginners** who want to make their **first Unity game**. Whether you're new to game development or just getting started with Unity, this guide will walk you through the process in a simple and clear way.

We’ll be using **Unity** and **Visual Studio 2022**, and all code changes will be documented right here as commits are made.  

The Tutorial is been inspired from <a href="http://www.youtube.com/@GMTK">Game Maker's Toolkit's</a> video, <a href="https://www.youtube.com/watch?v=XtQMytORBmM">Click here to watch</a>.

---

## 🛠️ 1. Getting Started

1. Download and Install **Unity** for your device from <a href="https://unity.com/download">here.</a>
2. Also Download and Install **Visual Studio 2022 IDE** from <a href="https://visualstudio.microsoft.com/vs/">Here<a>.
3. Make sure you have Installed **Unity Hub** as well as **Unity Editor (Latest Version)**.
4. Github(For Version Control)

## 📁 2. Setting Up Your Unity Project

1. Open Unity Hub > New Project.
2. Navigate to "Core" > Universal 2D.
3. Name your project.
4. Click "Create".

## 🧭 3. Understanding the Unity User Interface (UI)

When you open Unity, the layout might seem overwhelming at first — but don't worry, it's easy once you know what each panel does. Here's a quick breakdown:

### 🔳 Scene View
- This is your "workspace" — where you design and build your game.
- You can drag, move, rotate, and scale GameObjects here.
- Think of it like your level editor.

### 🎮 Game View
- This shows what the player will see when they play the game.
- Hit the ▶️ (Play) button at the top to preview the game in this window.

### 🧱 Hierarchy
- Lists **all GameObjects** in your current Scene.
- This is where you’ll find things like the Camera, Lights, and your Player object.
- You can drag things in and out to organize objects (like putting enemies inside a folder called "Enemies").

### ⚙️ Inspector
- When you select any GameObject, its properties show up here.
- You can change the position, size, color, add scripts, colliders, and more from this panel.

### 📁 Project
- This is your file manager inside Unity.
- Everything you import or create (scripts, images, audio, etc.) lives here in folders.

### 💬 Console
- Displays messages like errors, warnings, and print/debug logs from your scripts.
- Super useful for finding issues in your game.

---

🔄 **Tip:** You can rearrange or reset the layout anytime:  
Go to `Window > Layouts > Default` if something gets messed up.

---

## 🧩 4. Adding Your First GameObject

Now that you're familiar with the Unity interface, let's start adding things to your game!

### 📥 Importing Assets
To bring in images, sounds, or other files into Unity:
1. Find the **Assets** tab in the **Project** window.
2. Simply **drag and drop** your image (like a character sprite) into the Assets folder.
3. Unity will automatically import it and make it available to use in your scene.

> 📝 Tip: You can also organize your assets by creating folders like `Images`, `Audio`, `Prefabs`, and `Scripts`.

---

### 🎭 Creating a GameObject

1. Go to the **Hierarchy** window.
2. Right-click > `Create Empty`.
3. A new empty GameObject will appear in your Scene. Let's rename it to `Barb`:
   - Click the GameObject, press `F2` (or right-click > Rename).
   - Type `Barb` and hit Enter.

---

### 📌 Centering the Object Using the Inspector

1. With `Barb` selected, go to the **Inspector** tab.
2. Find the **Transform** component.
3. Set the **Position** values (X, Y, Z) to `0`, so it sits in the center of the canvas.

```text
Position: X = 0 | Y = 0 | Z = 0
```
#### 🎯 Pro Tip: You can also use the move tool (press W) in the Scene view to drag it around manually.

---

## 🎨 5. Making Your GameObject Visible – Adding a Sprite

Right now, `Barb` is just an empty GameObject — it doesn’t show up in the Scene because it has no visual component. Let’s fix that by adding a **Sprite Renderer** and assigning an image (sprite) to it.

---

### ➕ Add a Sprite Renderer Component

1. Select the `Barb` GameObject in the **Hierarchy**.
2. In the **Inspector**, click the **Add Component** button at the bottom.
3. Search for and select `Sprite Renderer`.

> This tells Unity: “Hey, I want this object to display an image.”

---

### 🖼️ Assign the Barb Sprite

1. In your **Project > Assets** folder, locate the sprite image you imported earlier (for example: `barb.png`).
2. Drag and drop the sprite into the **Sprite** field of the Sprite Renderer component (in the Inspector).

Once you do this, your `Barb` object will now be visible in the Scene!

> ✅ If the image doesn't appear, make sure the Sprite’s **Texture Type** (in the Import Settings) is set to `Sprite (2D and UI)`.

If the Sprite is not Visible, try changing the Position Value for Z of either **Main Camera** or **Barb**.
Now `Barb` has a visual — you're one step closer to bringing your character to life! 🎉
