# DESIGNATHON-2025: Unity AR/VR Construction Planning Platform

## 📌 Overview
The Unity AR/VR Construction Planning Platform is designed to enhance collaboration in construction projects by integrating real-time **3D modeling, AI-driven analysis, and AR visualization**. The platform enables **builders, 3D artists, and stakeholders** to interact with construction designs seamlessly.

## 🎯 Target Devices
- **Phase 1:** Android Tablets
- **Phase 2:** iPads
- **Phase 3:** Mobile Phones

## 🔑 1. User Roles & Responsibilities

### **Role-Based Access**

| Role | Responsibilities |
|------|----------------|
| **Admin/Organization Owner** | - Creates an organization if not part of one. <br> - Manages team roles & permissions. <br> - Monitors projects & access control. |
| **Builder (Project Owner)** | - Uploads & manages blueprints. <br> - Assigns access to 3D artists. <br> - Approves submitted 3D models. <br> - Reviews cost estimation & structural integrity reports. |
| **3D Artist** | - Works on assigned parts of the model. <br> - Submits 3D elements for approval. <br> - Collaborates with other artists in real-time. |
| **User (Client/Stakeholder)** | - Views available 3D models. <br> - Prints physical blueprints. <br> - Uses mobile AR to explore models. <br> - Adds interior elements to models. <br> - Sees real-time model updates. |
| **AI System (Automated Agent)** | - Runs cost estimation based on material & design. <br> - Evaluates structural integrity. <br> - Provides insights for optimization. |

## 🏗 2. Application Architecture

### **A. Core Functional Modules**

| Module | Description |
|--------|-------------|
| **Authentication & Organization Management** | - Firebase Authentication (Google, Email, Apple Sign-in). <br> - Organization creation & invitation system. |
| **Blueprint Upload & Processing** | - Builders upload blueprints (PDF, DWG, IFC, etc.). <br> - Automatic parsing for 3D modeling. |
| **3D Model Collaboration** | - Artists can work on separate components. <br> - Unity Netcode/Photon for real-time sync. <br> - Version control for model changes. |
| **User AR/VR Interaction** | - Users view & interact with 3D models. <br> - AR overlay for real-world alignment. <br> - Interior customization using asset libraries. |
| **AI-Powered Analysis** | - Cost estimation based on design & materials. <br> - Structural integrity simulation with physics-based stress testing. |
| **Real-Time Sync & Notifications** | - Updates sync across devices instantly. <br> - Builders get notifications when models are updated. |

## 💻 3. Development Tech Stack

| Component | Technology |
|-----------|------------|
| **Game Engine** | Unity (C#) |
| **Networking** | Photon / Unity Netcode |
| **AR/VR Framework** | ARCore (Android) / ARKit (iOS) / OpenXR |
| **Authentication & Backend** | Firebase Authentication, Firestore, Cloud Functions |
| **3D Modeling & Integration** | Blender, SketchUp, Pixyz Plugin for BIM formats |
| **AI & Simulation** | Unity ML-Agents, Python (TensorFlow/PyTorch for structural analysis) |
| **UI & Interaction** | Unity UI Toolkit, Shader Graph for custom rendering |

## 🚀 4. Implementation Details

### **A. Backend & Authentication**
- Firebase Authentication for **Google, Email, Apple Sign-in**.
- Firestore for **user role management & project data storage**.
- Cloud Functions for **real-time processing of cost and integrity analysis**.

### **B. Real-Time Collaboration**
- **Photon PUN / Unity Netcode** enables multiple users to work on **3D models simultaneously**.
- **Version control system** tracks changes and prevents conflicts.

### **C. AR/VR Visualization**
- **ARCore & ARKit** for placing models in real-world environments.
- **OpenXR** support for future expansion into VR headsets.

### **D. AI-Powered Cost & Structural Analysis**
- **Physics-Informed Neural Networks (PINNs)** for stress & load testing.
- **Regression models (XGBoost/LightGBM)** for cost prediction.

## 📌 5. User Journey

### **A. Builder Flow**
1. Logs in → Creates an organization (if new)
2. Uploads blueprints
3. Assigns 3D artists to specific model parts
4. Reviews AI-driven cost & structural analysis
5. Approves/rejects artist submissions
6. Monitors real-time updates & stakeholder feedback

### **B. 3D Artist Flow**
1. Logs in → Joins assigned project
2. Downloads assigned blueprint/model section
3. Creates & submits 3D assets
4. Collaborates in real-time with other artists
5. Submits work for builder approval

### **C. User (Client) Flow**
1. Logs in & browses available models
2. Views blueprints (physical & digital)
3. Uses mobile AR to place/explore the structure
4. Adds interior elements (furniture, walls, textures)
5. Sees real-time changes made by other stakeholders

## 📱 6. Features Breakdown by Device

| Feature | Tablet | Phone |
|---------|--------|-------|
| **Blueprint Upload** | ✅ | ❌ |
| **3D Model Editing** | ✅ | ❌ |
| **AR Model Viewing** | ✅ | ✅ |
| **Interior Customization** | ✅ | ✅ |
| **Cost Estimation & AI Analysis** | ✅ | ✅ |

## 🎨 7. UI Development
https://www.figma.com/design/FRIGY8OzF9QR2PJswBapP8/VNR-Design-A-Thon-2025-Q1?node-id=4-6&t=O2lwnkEQNzp0F3Px-1


## 🔮 8. Future Scope

| Feature | Future Implementation |
|---------|------------------------|
| **VR Support** | Extend compatibility to **VR headsets (Meta Quest, HTC Vive)**. |
| **BIM Model Import** | Full support for **Revit, IFC, and BIM file formats**. |
| **Haptic Feedback** | Implement **haptic interactions** for a more immersive AR/VR experience. |
| **AI-Based Design Optimization** | AI will suggest **optimal layouts** based on stress analysis. |
| **Voice Commands** | Hands-free interaction using **speech-to-text AI models**. |

## 📜 9. Conclusion
The **Unity AR/VR Construction Planning Platform** streamlines collaboration between **builders, 3D artists, and stakeholders** by integrating **real-time 3D modeling, AR visualization, and AI-driven analysis**. With an **intuitive role-based access system and cloud-powered real-time sync**, this platform is set to revolutionize construction planning!

---

### 🏗 Built with ❤️ for DESIGNATHON-2025 by Pixel Labs 🚀


