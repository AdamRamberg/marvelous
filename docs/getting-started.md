---
id: getting-started
title: Getting Started
sidebar_label: Getting Started
---

# Installation 
Marvelous can be installed via NPM. Add the following to your `manifest.json`:
```
{
    "scopedRegistries": [
        {
            "name": "Marvelous",
            "url": "https://registry.npmjs.org",
            "scopes": [
                "com.mambojambostudios.marvelous"
            ]
        }
    ],
    "dependencies": {
        ...
        "com.mambojambostudios.marvelous" : "1.0.2",
        ...
    }
}
```
[Check out Marvelous](https://www.npmjs.com/package/com.mambojambostudios.marvelous) on NPM to get the latest version.
