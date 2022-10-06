using System.Windows.Controls;
using System.Windows.Media;

namespace MaterialDesignThemes.Wpf;

public static class DataGridAssist
{
    private static readonly Thickness DefaultCellPaddingThickness = new Thickness(16, 8, 16, 8);
    private static readonly Thickness DefaultColumnHeaderPadding = new Thickness(16, 10, 16, 10);
    private static readonly CornerRadius DefaultCornerRadius = new CornerRadius(4);

    #region AttachedProperty : AutoGeneratedCheckboxStyleProperty
    public static readonly DependencyProperty AutoGeneratedCheckBoxStyleProperty
        = DependencyProperty.RegisterAttached("AutoGeneratedCheckBoxStyle", typeof(Style), typeof(DataGridAssist),
            new PropertyMetadata(default(Style), AutoGeneratedCheckBoxStylePropertyChangedCallback));

    public static Style GetAutoGeneratedCheckBoxStyle(DataGrid element)
        => (Style)element.GetValue(AutoGeneratedCheckBoxStyleProperty);
    public static void SetAutoGeneratedCheckBoxStyle(DataGrid element, Style value)
        => element.SetValue(AutoGeneratedCheckBoxStyleProperty, value);

    private static void AutoGeneratedCheckBoxStylePropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var dataGrid = (DataGrid)d;

        dataGrid.AutoGeneratingColumn -= SetGeneratedCheckboxColumnStyle;
        dataGrid.AutoGeneratingColumn += SetGeneratedCheckboxColumnStyle;
    }

    private static void SetGeneratedCheckboxColumnStyle(object? sender, DataGridAutoGeneratingColumnEventArgs e)
    {
        if (e.Column is DataGridCheckBoxColumn column &&
            sender is DataGrid dataGrid)
        {
            column.ElementStyle = GetAutoGeneratedCheckBoxStyle(dataGrid);
        }
    }
    #endregion

    #region AttachedProperty : AutoGeneratedEditingCheckBoxStyleProperty
    public static readonly DependencyProperty AutoGeneratedEditingCheckBoxStyleProperty
        = DependencyProperty.RegisterAttached("AutoGeneratedEditingCheckBoxStyle", typeof(Style), typeof(DataGridAssist),
            new PropertyMetadata(default(Style), AutoGeneratedEditingCheckBoxStylePropertyChangedCallback));

    public static Style GetAutoGeneratedEditingCheckBoxStyle(DataGrid element)
        => (Style)element.GetValue(AutoGeneratedEditingCheckBoxStyleProperty);
    public static void SetAutoGeneratedEditingCheckBoxStyle(DataGrid element, Style value)
        => element.SetValue(AutoGeneratedEditingCheckBoxStyleProperty, value);

    private static void AutoGeneratedEditingCheckBoxStylePropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var dataGrid = (DataGrid)d;

        dataGrid.AutoGeneratingColumn -= SetGeneratedCheckBoxEditingStyle;
        dataGrid.AutoGeneratingColumn += SetGeneratedCheckBoxEditingStyle;
    }

    private static void SetGeneratedCheckBoxEditingStyle(object? sender, DataGridAutoGeneratingColumnEventArgs e)
    {
        if (e.Column is DataGridCheckBoxColumn column &&
            sender is DataGrid dataGrid)
        {
            column.EditingElementStyle = GetAutoGeneratedEditingCheckBoxStyle(dataGrid);
        }
    }
    #endregion

    #region AttachedProperty : AutoGeneratedTextStyleProperty
    public static readonly DependencyProperty AutoGeneratedTextStyleProperty
        = DependencyProperty.RegisterAttached("AutoGeneratedTextStyle", typeof(Style), typeof(DataGridAssist),
            new PropertyMetadata(default(Style), AutoGeneratedTextStylePropertyChangedCallback));

    public static Style GetAutoGeneratedTextStyle(DataGrid element)
        => (Style)element.GetValue(AutoGeneratedTextStyleProperty);
    public static void SetAutoGeneratedTextStyle(DataGrid element, Style value)
        => element.SetValue(AutoGeneratedTextStyleProperty, value);

    private static void AutoGeneratedTextStylePropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var dataGrid = (DataGrid)d;

        dataGrid.AutoGeneratingColumn -= SetGeneratedTextColumnStyle;
        dataGrid.AutoGeneratingColumn += SetGeneratedTextColumnStyle;
    }

    private static void SetGeneratedTextColumnStyle(object? sender, DataGridAutoGeneratingColumnEventArgs e)
    {
        if (e.Column is System.Windows.Controls.DataGridTextColumn column &&
            sender is DataGrid dataGrid)
        {
            column.ElementStyle = GetAutoGeneratedTextStyle(dataGrid);
        }
    }
    #endregion

    #region AttachedProperty : AutoGeneratedEditingTextStyleProperty
    public static readonly DependencyProperty AutoGeneratedEditingTextStyleProperty
        = DependencyProperty.RegisterAttached("AutoGeneratedEditingTextStyle", typeof(Style), typeof(DataGridAssist),
            new PropertyMetadata(default(Style), AutoGeneratedEditingTextStylePropertyChangedCallback));

    public static Style GetAutoGeneratedEditingTextStyle(DataGrid element)
        => (Style)element.GetValue(AutoGeneratedEditingTextStyleProperty);
    public static void SetAutoGeneratedEditingTextStyle(DataGrid element, Style value)
        => element.SetValue(AutoGeneratedEditingTextStyleProperty, value);

    private static void AutoGeneratedEditingTextStylePropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var dataGrid = (DataGrid)d;

        dataGrid.AutoGeneratingColumn -= SetGeneratedTextColumnEditingStyle;
        dataGrid.AutoGeneratingColumn += SetGeneratedTextColumnEditingStyle;
    }

    private static void SetGeneratedTextColumnEditingStyle(object? sender, DataGridAutoGeneratingColumnEventArgs e)
    {
        if (e.Column is System.Windows.Controls.DataGridTextColumn column &&
            sender is DataGrid dataGrid)
        {
            column.EditingElementStyle = GetAutoGeneratedEditingTextStyle(dataGrid);
        }
    }
    #endregion

    #region AttachedProperty : CellPaddingProperty
    public static readonly DependencyProperty CellPaddingProperty
        = DependencyProperty.RegisterAttached("CellPadding", typeof(Thickness), typeof(DataGridAssist),
            new FrameworkPropertyMetadata(DefaultCellPaddingThickness, FrameworkPropertyMetadataOptions.Inherits));

    public static Thickness GetCellPadding(DataGrid element)
        => (Thickness)element.GetValue(CellPaddingProperty);
    public static void SetCellPadding(DataGrid element, Thickness value)
        => element.SetValue(CellPaddingProperty, value);
    #endregion

    #region AttachedProperty : SelectedCellBorderBrushProperty
    public static readonly DependencyProperty SelectedCellBorderBrushProperty
        = DependencyProperty.RegisterAttached("SelectedCellBorderBrush", typeof(Brush), typeof(DataGridAssist),
            new PropertyMetadata(null));

    public static Brush GetSelectedCellBorderBrush(DataGrid element)
        => (Brush)element.GetValue(SelectedCellBorderBrushProperty);
    public static void SetSelectedCellBorderBrush(DataGrid element, Brush value)
        => element.SetValue(SelectedCellBorderBrushProperty, value);
    #endregion

    #region AttachedProperty : ColumnHeaderPaddingProperty
    public static readonly DependencyProperty ColumnHeaderPaddingProperty
        = DependencyProperty.RegisterAttached("ColumnHeaderPadding", typeof(Thickness), typeof(DataGridAssist),
            new FrameworkPropertyMetadata(DefaultColumnHeaderPadding, FrameworkPropertyMetadataOptions.Inherits));

    public static Thickness GetColumnHeaderPadding(DataGrid element)
        => (Thickness)element.GetValue(ColumnHeaderPaddingProperty);
    public static void SetColumnHeaderPadding(DependencyObject element, Thickness value)
        => element.SetValue(ColumnHeaderPaddingProperty, value);
    #endregion

    #region AttachedProperty : EnableEditBoxAssistProperty
    public static readonly DependencyProperty EnableEditBoxAssistProperty
        = DependencyProperty.RegisterAttached("EnableEditBoxAssist", typeof(bool), typeof(DataGridAssist),
            new PropertyMetadata(default(bool), EnableEditBoxAssistPropertyChangedCallback));

    public static bool GetEnableEditBoxAssist(DataGrid element)
        => (bool)element.GetValue(EnableEditBoxAssistProperty);
    public static void SetEnableEditBoxAssist(DataGrid element, bool value)
        => element.SetValue(EnableEditBoxAssistProperty, value);

    private static void EnableEditBoxAssistPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var dataGrid = (DataGrid)d;
        var enableCheckBoxAssist = (bool)e.NewValue;

        if (enableCheckBoxAssist)
        {
            // Register for bubbling events from cells, even when the cell handles them (thus the 'true' parameter)
            dataGrid.AddHandler(UIElement.MouseLeftButtonDownEvent, (RoutedEventHandler)OnMouseLeftButtonDown, true);
            dataGrid.PreviewKeyDown += EditOnSpacebarPress;
        }
        else
        {
            dataGrid.RemoveHandler(UIElement.MouseLeftButtonDownEvent, (RoutedEventHandler)OnMouseLeftButtonDown);
            dataGrid.PreviewKeyDown -= EditOnSpacebarPress;
        }
    }

    // This relay is only needed because the UIElement.AddHandler() has strict requirements for the signature of the passed Delegate
    private static void OnMouseLeftButtonDown(object sender, RoutedEventArgs e) => AllowDirectEditWithoutFocus(sender, (MouseButtonEventArgs)e);

    #endregion

    #region AttachedProperty : CornerRadiusProperty
    public static readonly DependencyProperty CornerRadiusProperty
        = DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(DataGridAssist),
            new PropertyMetadata(DefaultCornerRadius));

    public static CornerRadius GetCornerRadius(DataGrid element)
        => (CornerRadius)element.GetValue(CornerRadiusProperty);
    public static void SetCornerRadius(DataGrid element, CornerRadius value)
        => element.SetValue(CornerRadiusProperty, value);
    #endregion

    private static void EditOnSpacebarPress(object sender, KeyEventArgs e)
    {
        var dataGrid = (DataGrid)sender;
        if (e.Key == Key.Space && e.OriginalSource is DataGridCell { IsReadOnly: false } cell)
        {
            if (cell.Column is DataGridComboBoxColumn ||
                cell.Column is System.Windows.Controls.DataGridTextColumn)
            {
                dataGrid.BeginEdit();
                e.Handled = true;
            }
        }
    }

    /// <summary>
    /// Allows editing of components inside of a data grid cell with a single left click.
    /// </summary>
    private static void AllowDirectEditWithoutFocus(object sender, MouseButtonEventArgs mouseArgs)
    {
        var originalSource = (DependencyObject)mouseArgs.OriginalSource;
        var dataGridCell = originalSource
            .GetVisualAncestry()
            .OfType<DataGridCell>()
            .FirstOrDefault();

        // Readonly has to be handled as the pass-through ignores the
        // cell and interacts directly with the content
        if (dataGridCell?.IsReadOnly ?? true)
        {
            return;
        }

        if (dataGridCell.Content is UIElement element)
        {
            var dataGrid = (DataGrid)sender;
            // If it is a DataGridTemplateColumn we want the
            // click to be handled naturally by the control
            if (dataGridCell.Column.GetType() == typeof(DataGridTemplateColumn))
            {
                return;
            }
            if (dataGridCell.IsEditing)
            {
                // If the cell is already being edited, we don't want to (re)start editing
                return;
            }

            dataGrid.CurrentCell = new DataGridCellInfo(dataGridCell);
            dataGrid.BeginEdit();

            switch (dataGridCell.Content)
            {
                case TextBoxBase textBox:
                {
                    // Send a 'left-click' routed event to the TextBox to place the I-beam at the position of the mouse cursor
                    var mouseDownEvent = new MouseButtonEventArgs(mouseArgs.MouseDevice, mouseArgs.Timestamp, mouseArgs.ChangedButton)
                    {
                        RoutedEvent = Mouse.MouseDownEvent,
                        Source = mouseArgs.Source
                    };
                    textBox.RaiseEvent(mouseDownEvent);
                    break;
                }

                case ToggleButton toggleButton:
                {
                    // Check if the cursor actually hit the checkbox and not just the cell
                    var mousePosition = mouseArgs.GetPosition(element);
                    var elementHitBox = new Rect(element.RenderSize);
                    if (elementHitBox.Contains(mousePosition))
                    {
                        // Send a 'left click' routed command to the toggleButton to toggle the state
                        var newMouseEvent = new MouseButtonEventArgs(mouseArgs.MouseDevice, mouseArgs.Timestamp, mouseArgs.ChangedButton)
                        {
                            RoutedEvent = Mouse.MouseDownEvent,
                            Source = dataGrid
                        };

                        toggleButton.RaiseEvent(newMouseEvent);
                    }
                    break;
                }

                // Open the dropdown explicitly. Left clicking is not
                // viable, as it would edit the text and not open the
                // dropdown
                case ComboBox comboBox:
                {
                    comboBox.IsDropDownOpen = true;
                    break;
                }
            }
        }
    }
}