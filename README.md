# 🐉 AR Dragon Image Tracking App

An Augmented Reality app built in **Unity** using **AR Foundation**, **ARCore**, and **C#**, which spawns and animates a dragon when an image target is detected.

---

## 🧰 Tech Stack

- Unity (2021.3 LTS or later)
- AR Foundation
- ARCore XR Plugin
- C# (for dragon movement/logic)
- Android or iOS with AR support

---

## 🚀 Features

- Image tracking via AR Foundation
- Spawns a dragon prefab on image detection
- Dragon follows the tracked image
- Custom animation or movement via script

---

## 📁 Project Setup

### 1. Install Dependencies

- Open Unity and create a 3D project
- Go to `Window > Package Manager` and install:
  - AR Foundation
  - ARCore XR Plugin
  - (Optional) ARKit XR Plugin for iOS

### 2. XR Plug-in Management

- Go to `Edit > Project Settings > XR Plug-in Management`
- Enable:
  - **ARCore** for Android
  - (Optional) **ARKit** for iOS

### 3. Scene Setup

- Add the following GameObjects:
  - `AR Session`
  - `AR Session Origin`
    - Contains `AR Camera`
- Add **AR Tracked Image Manager** to `AR Session Origin`

### 4. Reference Image Library

- Create: `Assets > Create > XR > Reference Image Library`
- Add your target image(s)
- Set **physical size** (e.g., 0.1m)

