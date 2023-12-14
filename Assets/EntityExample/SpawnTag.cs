// tags for spawning things
//-------------------------------------------//

using Unity.Burst;
using Unity.Entities;

// any entities found with this tag will be spawned
[BurstCompile]
public struct SpawnTag : IComponentData { }

// any entity that is spawned will be given this tag
// (it's used for deleting spawns)
public struct SpawnedTag : IComponentData { }