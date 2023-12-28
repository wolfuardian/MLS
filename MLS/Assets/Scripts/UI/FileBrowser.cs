using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class FileBrowser : MonoBehaviour
{
    public GameObject fileButtonPrefab;
    public Transform  fileListContent;

    private string currentPath;

    void Start()
    {
        currentPath = Application.dataPath;
        ShowFilesInDirectory(currentPath);
    }

    void ShowFilesInDirectory(string path)
    {
        foreach (Transform child in fileListContent)
        {
            Destroy(child.gameObject);
        }

        var directories = Directory.GetDirectories(path);
        var files       = Directory.GetFiles(path);

        foreach (var directory in directories)
        {
            var button = Instantiate(fileButtonPrefab, fileListContent).GetComponent<Button>();
            button.GetComponentInChildren<Text>().text = Path.GetFileName(directory);
            button.onClick.AddListener(() => ShowFilesInDirectory(directory));
        }

        foreach (var file in files)
        {
            var button = Instantiate(fileButtonPrefab, fileListContent).GetComponent<Button>();
            button.GetComponentInChildren<Text>().text = Path.GetFileName(file);
            button.onClick.AddListener(() => FileSelected(file));
        }
    }

    void FileSelected(string filePath)
    {
        Debug.Log("選擇的文件: " + filePath);
    }
}