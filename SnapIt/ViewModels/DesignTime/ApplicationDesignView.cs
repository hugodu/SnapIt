﻿using SnapIt.Common.Entities;
using SnapIt.Common.Graphics;
using SnapIt.Common.Mvvm;
using Point = SnapIt.Common.Graphics.Point;
using Size = SnapIt.Common.Graphics.Size;

namespace SnapIt.ViewModels.DesignTime;

public class ApplicationDesignView
{
    public ObservableCollection<SnapScreen> SnapScreens { get; set; }
    public ObservableCollection<Layout> Layouts { get; set; }
    public SnapAreaTheme Theme { get; set; } = new SnapAreaTheme();
    public ObservableCollectionWithItemNotify<ApplicationGroup> ApplicationGroups { get; set; }
    public ObservableCollection<ApplicationItem> ListApplicationItem { get; set; }
    public ObservableCollection<ApplicationItem> FilteredlistApplicationItem { get; set; }
    public ApplicationGroup SelectedApplicationGroup { get; set; }
    public bool IsApplicationItemOpen { get; set; } = false;
    public bool IsMoveApplicationItemOpen { get; set; } = false;
    public bool IsListApplicationItemDialogOpen { get; set; } = false;
    public ApplicationItem SelectedApplicationItem { get; set; }
    public ApplicationItem SelectedListApplicationItem { get; set; }

    public ObservableCollection<int> AreaNumbers { get; set; }

    public ApplicationDesignView()
    {
        AreaNumbers = new ObservableCollection<int>
        {
            1,2,3,4,5,6
        };
        Layouts = new ObservableCollection<Layout>
        {
            new Layout
            {
                Name = "Layout 1",
                Size = new Size(500, 200),
                AreaPadding = 0,
                LayoutLines = new List<Line>
                {
                    new Line
                    {
                        Point=new Point(150,0),
                        Size = new Size(0,200)
                    },
                     new Line
                    {
                        Point=new Point(150,100),
                        Size = new Size(350,0),
                        SplitDirection = SplitDirection.Horizontal
                    },
                     new Line
                    {
                        Point=new Point(325,100),
                        Size = new Size(0,100)
                    }
                },
                LayoutOverlays = new List<LayoutOverlay>
                {
                    new LayoutOverlay
                    {
                        Point= new Point(100,0),
                        Size= new Size(100,100)
                    }
                },
                Theme = Theme
            },
            new Layout
            {
                Name = "Layout 2",
                Size = new Size(1436, 700.8),
                Lines = new List<Line>
                {
                    new Line
                    {
                        Point=new Point(259.904414003044,0),
                        Size = new Size(0,700.8)
                    },
                     new Line
                    {
                        Point=new Point( 1230.4596651446,0),
                        Size = new Size(0,700.8 )
                    },
                     new Line
                    {
                        Point=new Point(259.904414003044,471.072897196262 ),
                        Size = new Size(970.555251141553,0 ),
                        SplitDirection = SplitDirection.Horizontal
                    },
                     new Line
                    {
                        Point=new Point(455.331811263318,471.072897196262 ),
                        Size = new Size(0,229.727102803738 )
                    },
                     new Line
                    {
                        Point=new Point(567.733637747336,0 ),
                        Size = new Size( 0,471.072897196262)
                    },
                     new Line
                    {
                        Point=new Point(567,235.5 ),
                        Size = new Size(663,0 ),
                        SplitDirection = SplitDirection.Horizontal
                    },
                     new Line
                    {
                        Point=new Point(898.5,235 ),
                        Size = new Size( 0,236)
                    },
                     new Line
                    {
                        Point=new Point(842.5,471 ),
                        Size = new Size( 0,229)
                    }
                },
                LayoutOverlays = new List<LayoutOverlay>
                {
                    new LayoutOverlay
                    {
                        Point= new Point(100,0),
                        Size= new Size(1000,600)
                    }
                },
                Theme = Theme
            },
            new Layout
            {
                Name = "3 Part Horizontal Reverse",
                Theme = Theme
            },
            new Layout
            {
                Name = "Layout 4",
                Theme = Theme
            }
        };

        var first = new Rect
        {
            X = 0,
            Y = 0,
            Width = 300,
            Height = 200
        };
        var second = new Rect
        {
            X = 300,
            Y = 100,
            Width = 100,
            Height = 100
        };
        SnapScreens = new ObservableCollection<SnapScreen>
        {
            new SnapScreen( )
            {
                DeviceNumber = "1",
                Primary = "Primary",
                Resolution = "1920 x 1080",
                Layout = Layouts[0],
                WorkingArea = first,
                Bounds = first,
                IsActive = false
            },
            new SnapScreen() {
                DeviceNumber = "2",
                IsActive = true,
                Primary = null,
                Resolution = "3440 x 1440",
                Layout = Layouts[1],
                WorkingArea = second,
                Bounds = second
            }
        };

        SnapScreens[0].Layout = Layouts[1];
        SnapScreens[1].Layout = Layouts[0];

        ApplicationGroups = new ObservableCollectionWithItemNotify<ApplicationGroup>
        {
            new ApplicationGroup
            {
                Name = "Start Day",
                ApplicationAreas = new ObservableCollectionWithItemNotify<ApplicationArea>
                {
                    new ApplicationArea(1)
                    {
                        Applications = new ObservableCollectionWithItemNotify<ApplicationItem>
                        {
                            new ApplicationItem
                            {
                                Title= "Title 1",
                                Path ="Test 1",
                                Arguments = "Arguments 1"
                            },
                            new ApplicationItem
                            {
                                Title= "Cider",
                                Path ="explorer.exe",
                                Arguments = "shell:appsFolder\\27554FireDevElijahKlauman.CiderAlpha_270bejk4xgzqp!CiderAlpha"
                            }
                        }
                    }
                }
            },
            new ApplicationGroup
            {
                Name = "Work",
                ApplicationAreas = new ObservableCollectionWithItemNotify<ApplicationArea>
                {
                    new ApplicationArea(1)
                    {
                        Applications = new ObservableCollectionWithItemNotify<ApplicationItem>
                        {
                            new ApplicationItem
                            {
                                AreaNumber =4,
                                Title= "Cider",
                                Path ="explorer.exe",
                                Arguments = "shell:appsFolder\\27554FireDevElijahKlauman.CiderAlpha_270bejk4xgzqp!CiderAlpha"
                            },
                            new ApplicationItem
                            {
                                Title= "Title 2",
                                Path ="Test 2",
                                Arguments = "Arguments 2"
                            }
                        }
                    },
                    new ApplicationArea(2)
                    {
                        Applications = new ObservableCollectionWithItemNotify<ApplicationItem>
                        {
                            new ApplicationItem
                            {
                                Title= "Title 1",
                                Path ="Test 1"
                            },
                            new ApplicationItem
                            {
                                Title= "Title 2",
                                Path ="Test 2"
                            },
                            new ApplicationItem
                            {
                                Title= "Title 3",
                                Path ="Test 3"
                            },
                            new ApplicationItem
                            {
                                Title= "Title 2",
                                Path ="Test 2"
                            },
                            new ApplicationItem
                            {
                                Title= "Title 3",
                                Path ="Test 3"
                            },
                            new ApplicationItem
                            {
                                Title= "Title 2",
                                Path ="Test 2"
                            },
                            new ApplicationItem
                            {
                                Title= "Title 3",
                                Path ="Test 3"
                            }
                        }
                    }
                }
            }
        };

        //ApplicationGroups = null;

        //return;

        SelectedApplicationGroup = ApplicationGroups.Last();
        SelectedApplicationItem = SelectedApplicationGroup.ApplicationAreas.First().Applications.First();

        ListApplicationItem = new ObservableCollection<ApplicationItem>(ApplicationGroups.SelectMany(i => i.ApplicationAreas.SelectMany(j => j.Applications)).ToList());
        FilteredlistApplicationItem = ListApplicationItem;
        SelectedListApplicationItem = ListApplicationItem.First();
    }
}