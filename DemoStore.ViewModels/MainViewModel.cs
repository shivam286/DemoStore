using DemoStore.DataAccess.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Windows.Controls;
using System.Windows.Input;

public class MainViewModel : INotifyPropertyChanged
{
    private Queue<Order> _queue;


    public MainViewModel()
    {
        // Subscribe to the NetworkAvailabilityChanged event
        NetworkChange.NetworkAvailabilityChanged += NetworkAvailabilityChangedHandler;

        // Check the initial network status
        IsOnline = NetworkInterface.GetIsNetworkAvailable();
        StatusMessage = IsOnline ? "Online" : "Offline";
        _queue = new Queue<Order>();
        // Initialize the command to synchronize the database
        SyncDatabaseCommand = new RelayCommand(SyncDatabase, CanSyncDatabase);
    }

    public MainViewModel(Queue<Order> queue)
    {
        // Subscribe to the NetworkAvailabilityChanged event
        NetworkChange.NetworkAvailabilityChanged += NetworkAvailabilityChangedHandler;

        // Check the initial network status
        IsOnline = NetworkInterface.GetIsNetworkAvailable();
        StatusMessage = IsOnline ? "Online" : "Offline";

        // Initialize the command to synchronize the database
        SyncDatabaseCommand = new RelayCommand(SyncDatabase, CanSyncDatabase);

        _queue = queue;
    }

    private bool _isOnline;
    public bool IsOnline
    {
        get { return _isOnline; }
        set
        {
            if (_isOnline != value)
            {
                _isOnline = value;
                OnPropertyChanged(nameof(IsOnline));
            }
        }
    }

    private string _statusMessage;
    public string StatusMessage
    {
        get { return _statusMessage; }
        set
        {
            if (_statusMessage != value)
            {
                _statusMessage = value;
                OnPropertyChanged(nameof(StatusMessage));
            }
        }
    }

    public ICommand SyncDatabaseCommand { get; }

    public void NetworkAvailabilityChangedHandler(object sender, NetworkAvailabilityEventArgs e)
    {
        IsOnline = e.IsAvailable;
        StatusMessage = IsOnline ? "Online" : "Offline";

        if (IsOnline)
        {
            try
            {
                foreach (Order o in _queue)
                {
                    //send data to api
                    //dequeue the _orderList
                }
            }
            catch (Exception ex)
            {

            }
        }
    }

    private void SyncDatabase(object parameter)
    {
        // Perform database synchronization logic here
        // You might use a service or repository to handle the actual synchronization
        Console.WriteLine("Syncing the database...");
    }

    private bool CanSyncDatabase(object parameter)
    {
        return IsOnline; // Allow synchronization only when online
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
