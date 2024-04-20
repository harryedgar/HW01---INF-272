https://github.com/harryedgar/HW01---INF-272/assets/143422915/464a89a3-0687-4d62-97ca-1579f891e710

## 1. High-Level Case Description
RescueBus is an innovative ambulance booking system designed for the city of Townsville, addressing Mayor George Thompson's request for an emergency service system. The platform enables citizens to book ambulances quickly and efficiently, including emergency situations through an S.O.S. feature. With improved response times, RescueBus aims to save lives, such as Jane, a mother potentially facing a medical emergency. The system manages drivers and vehicles separately, generating booking confirmation reports and ride history for enhanced efficiency and accountability.

## 2. Standard Requirements
- Adherence to wireframes for layout guidance.
- Creativity and neatness in design and layout.
- Utilization of specified technology parameters.
- Persistence of dynamic data using localStorage.
- Inclusion of mandatory functionalities without additions.

## 3. List of System Requirements
### 3.1. Navigation Bar
- Each screen includes a navigation bar with links to Home, Ride History, and Manage.

### 3.2. Home Page
- Functions as the application's homepage.
- BOOK AMBULANCE button directs to Select a Service.
- S.O.S. button creates emergency bookings.

### 3.3. Select a Service
- Users select their desired service for booking.
- Six service options provided with redirection to Booking Form upon selection.

### 3.4. Booking Form
- Creates bookings with specific service details.
- Displays selected service title and input fields.
- Filters Vehicle and Driver dropdowns based on service.
- Saves booking details to localStorage with a unique identifier.

### 3.5. Booking Confirmed
- Displays confirmation details after booking.
- Includes BookingID, date, and associated driver and vehicle images.

### 3.6. Ride History
- Lists all booked rides, distinguishing S.O.S. bookings.
- Allows access to associated Booking Confirmed screens.

### 3.7. Driver and Vehicle Management
- Manages drivers and vehicles.
- Enables creation, updating, and deletion.
- Supports searching for drivers based on first name and service type.
- Provides export functionality for vehicle lists to a text file.

This README provides an overview of the RescueBus system's key functionalities and requirements for developers and users alike. For detailed implementation instructions, please refer to the project documentation.
