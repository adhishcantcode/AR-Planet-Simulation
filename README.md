# AR Planet Simulation (Unity)

An interactive **Augmented Reality (AR) Solar System experience** built with Unity. This project allows users to **select planets and place them in the real world using AR**, creating an immersive and educational space simulation.

---

## Features

* **Planet Selection UI**

  * Swipe or click through different planets (Earth, Mercury, etc.)
  * Smooth carousel-style navigation

* **AR Placement**

  * Place planets in your real-world environment using AR
  * Surface detection and anchoring

* **Realistic Planet Models**

  * High-quality textures and spherical models
  * Scaled visuals for better understanding

* **Interactive Experience**

  * Rotate and view planets from all angles
  * Switch between planets seamlessly

* **Simple Navigation**

  * Back button to return to selection screen
  * Clean and minimal UI

---

## Tech Stack

* **Game Engine:** Unity (2021+ recommended)
* **Language:** C#
* **AR Framework:** AR Foundation / ARCore / ARKit
* **Platform:** Android / iOS (AR-supported devices)

---

## Project Structure

```bash
Assets/
│── Import/            # Imported assets (models, textures, planet resources)
│── Materials/         # Materials for planets and rendering
│── Scenes/            # Unity scenes (UI scene, AR scene)
│── Scripts/           # C# scripts (carousel, AR placement, controls)
│── TextMesh Pro/      # Text rendering essentials
│── XR/                # AR/XR configuration and settings
```

---

## Setup Instructions

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/ar-planet-simulation.git
   ```

2. Open the project in Unity

3. Install required packages:

   * AR Foundation
   * ARCore XR Plugin (Android) / ARKit (iOS)

4. Switch platform:

   * `File → Build Settings → Android / iOS`

5. Enable:

   * Camera permissions
   * AR support in XR settings

6. Build & run on a real device (AR won’t work in editor)

---

## How to Use

1. Launch the app
2. Browse planets using left/right arrows
3. Select a planet
4. Point your camera to a flat surface
5. Tap to place the planet in AR
6. Move around and explore

---

## Screenshots / Demo

### Planet Selection UI

![Planet Selection](./images/earth_ui.png)
![Planet Selection](./images/mercury_ui.png)

### AR Placement

![AR Mercury](./images/ar_mercury.png)
![AR Venus](./images/ar_venus.png)

> Place your screenshots inside a folder named `images` in your repository and update file names if needed.

---

## Learning Outcomes

* Understanding AR development in Unity
* Working with 3D models and textures
* Implementing UI navigation systems
* Using real-world spatial tracking

---

## Future Improvements

* Add all 8 planets + moons
* Planet information panel (facts, size, distance)
* Scale comparison mode
* Orbit simulation
* Multiplayer AR experience

---

## Contributing

Contributions are welcome.

1. Fork the repo
2. Create a new branch
3. Make your changes
4. Submit a pull request

---

## License

This project is open-source and available under the **MIT License**.

---

## Author

Adhish Gupta

---

## Support

If you like this project, consider giving it a star on GitHub.

---
