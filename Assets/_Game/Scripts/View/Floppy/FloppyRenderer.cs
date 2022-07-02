using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace _Game.Scripts.View.Floppy
{
    public class FloppyRenderer : BaseView
    {
        [SerializeField] private LineRenderer _renderer;
        [SerializeField] private List<Transform> _points;

        private void Start()
        {
            _renderer.positionCount = _points.Count;
        }

        private void Update()
        {
            DrawLine();
        }

        private void OnDrawGizmos()
        {
            _renderer.positionCount = _points.Count;
            DrawLine();
        }

        private void DrawLine()
        {
            _renderer.SetPositions(_points.Select(item => item.position).ToArray());
        }
    }
}