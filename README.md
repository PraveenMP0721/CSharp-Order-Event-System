# CSharp Order Event System

## Overview
A console-based Real-Time Order Notification System demonstrating:

- Delegates
- Multicast Delegates
- Events
- Publisher Subscriber Pattern
- Dynamic Subscription and Unsubscription

## Project Structure

```
OrderApp
│
├── Program.cs
├── Order.cs
├── OrderProcessor.cs
│
└── Services
    ├── EmailService.cs
    ├── SMSService.cs
    └── LoggerService.cs
```

## Features

- Order Processing
- Email Notifications
- SMS Notifications
- Logging Service
- Event Driven Architecture
- Loose Coupling

## Concepts Used

- Custom Delegates
- Multicast Delegates
- Events
- Publisher Subscriber Model
- Exception Handling
- Null-safe Invocation

## Sample Output

```
Order Placed: 101
Email sent to customer
SMS sent to customer
Order logged successfully

After SMS Unsubscribed:

Order Placed: 102
Email sent to customer
Order logged successfully
```

## Author

Praveen Pujeri
