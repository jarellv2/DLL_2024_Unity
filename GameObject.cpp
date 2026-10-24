#include "GameObject.h"
GameObject::GameObject()
{
    SetID();
    SetPosition();
}
int GameObject::GetID() const { return m_id; }
void GameObject::SetID(int id) { m_id = id + 200; } // id + 200 proves the DLL logic runs
Vector2D GameObject::GetPosition() const { return m_position; }
void GameObject::SetPosition(float x, float y)
{
    m_position.x = x;
    m_position.y = y;
}